#ifndef DBSCLASS_H
#define DBSCLASS_H
//#include <QMainWindow>

#include <QtSql>
#include <QDebug>
#include <QFileInfo>
#include <QFileDialog>
#include <QMessageBox>
#include <QWidget>
#include <QTableView>
#include <QFontComboBox>
#include <QLineEdit>
#include <QLabel>
#include <QComboBox>
#include <QModelIndex>
#include<QFont>
#include<QPainter>
#include<QDesktopServices>
#include<QPrinter>
#include<QTextEdit>
#include<QStringListModel>

class dbsclass
{
public:
    dbsclass();
    void fill_combo(QFontComboBox *ctbx,QString qry);
    void fill_combobox(QComboBox *ctbx,QString qry);
    void fill_combobox(QComboBox *ctbx,QString qry,int v);
    void fill_tbx(QLineEdit *tbx,QString qry,int v);
    QString fill_string(QString qry,int v);
    QByteArray fill_blob(QString qry,int v);
    double fill_array(QString qry,int v);
    int tbl_sz(QString qry);
    void fill_label(QLabel *lbl,QString qry,int v);
    bool chkpass(QString qry);
    QString fill_array_string(QString qry,int v);

    QSqlDatabase db;
    bool conn(){
        db=QSqlDatabase::addDatabase("QMYSQL3");
        //db.setDatabaseName("/usr/share/mysql-workbench/data/data.db");
        db.setHostName("localhost");
        db.setDatabaseName("ral");
        db.setUserName("root");
        db.setPassword("root");
        //db.setHostName("127.0.0.1");
        db.setPort(3306);
        if(!db.open()){
            return false;
            QMessageBox msg;
            msg.setText("Connection Faild.");
            msg.exec();
        }
        else{
            return true;}
    }

    bool conn(QStringList lst){
        db=QSqlDatabase::addDatabase("QMYSQL3");
        //db.setDatabaseName("/usr/share/mysql-workbench/data/data.db");
        db.setHostName(lst.value(0));
        db.setDatabaseName(lst.value(1));
        db.setUserName(lst.value(2));
        db.setPassword(lst.value(3));
        //db.setConnectOptions("CLIENT_SSL=1;CLIENT_IGNORE_SPACE=1");
        //db.setHostName("127.0.0.1");
        QString p=lst.value(5);
        db.setPort(p.toInt());
        if(!db.open()){
            return false;
            //QMessageBox msg;
            //msg.setText("Connection Faild.");
            // msg.exec();
        }
        else{
            return true;}
    }



    void conn_close(){
        db.close();
        db=QSqlDatabase();
        db.removeDatabase(QSqlDatabase::defaultConnection);
    }

    void queryfeeder(QString q){

        db.driver()->beginTransaction();
        QSqlQuery qry;
        qry.prepare(q);
        if(qry.exec()){
            /* QMessageBox msg;
            msg.setText("Operation Succesfull");
            msg.exec();*/
        }
        else{
            QSqlError er=qry.lastError();
            QString e=er.text();
            QMessageBox msg;
            msg.setText(e);
            msg.exec();
            db.rollback();
        }

        db.driver()->commitTransaction();

    }
    void queryfeeder(QString q,QByteArray ba,QString blb){

        db.driver()->beginTransaction();
        QSqlQuery qry;
        qry.prepare(q);
        qry.bindValue(blb,ba);
        if(qry.exec()){
            /* QMessageBox msg;
            msg.setText("Operation Succesfull");
            msg.exec();*/
        }
        else{
            QSqlError er=qry.lastError();
            QString e=er.text();
            QMessageBox msg;
            msg.setText(e);
            msg.exec();
            db.rollback();
        }

        db.driver()->commitTransaction();

    }
    void tv_display(QTableView *qtv,QString q);

    QString recent_time(){
        QString q="SELECT CURTIME()";
        return fill_string(q,0);
    }
    QString recent_date(){
        QString q="SELECT CURDATE()";
        return fill_string(q,0);
    }

    void queryfeeder(QLineEdit *tbx,QString q){

        db.driver()->beginTransaction();
        QSqlQuery qry;
        qry.prepare(q);
        if(qry.exec()){
            tbx->setText(qry.lastInsertId().toString());
        }
        else{
            QSqlError er=qry.lastError();
            QString e=er.text();
            QMessageBox msg;
            msg.setText(e);
            msg.exec();
            db.rollback();
        }

        db.driver()->commitTransaction();

    }
    void queryfeeder(QComboBox *ctbx,QString q){

        db.driver()->beginTransaction();
        QSqlQuery qry;
        qry.prepare(q);
        if(qry.exec()){
            ctbx->setEditText(qry.lastInsertId().toString());
        }
        else{
            QSqlError er=qry.lastError();
            QString e=er.text();
            QMessageBox msg;
            msg.setText(e);
            msg.exec();
            db.rollback();
        }

        db.driver()->commitTransaction();

    }

    void search_tv(QString txt,QTableView *tv){
        QModelIndex index;
        int row=tv->model()->rowCount(QModelIndex());
        int col=tv->model()->columnCount(QModelIndex());
        for(int i=0;i<row;i++){
            for(int j=0;j<col;j++){
                index=tv->model()->index(i,j,QModelIndex());
                if(tv->model()->data(index).toString().contains(txt)){
                    tv->selectRow(i);
                    tv->scrollTo(index);
                }
            }
        }
    }
    void csv_exp(QString str,QTableView *tv){
        // QString newName = QFileDialog::getSaveFileName();
        QString filters("CSV files (*.csv);;Text files (*.txt);;All files (*.*)");
        QString defaultFilter("Text files (*.txt)");

        /* Static method approach */
        QString newName=QFileDialog::getSaveFileName(0, "Save file", QDir::currentPath(),filters, &defaultFilter);
        QString a="\n";
        int sz=tv->model()->columnCount(QModelIndex());
        for (int i=0;i<sz;i++){
            a+=tv->model()->headerData(i,Qt::Horizontal,Qt::DisplayRole).toString()+",";
        }
        newName+=".csv";
        QFile file(newName);
        file.open(QIODevice::WriteOnly | QIODevice::Text);
        QTextStream out(&file);
        out <<str<<a;
        QModelIndex index;
        int row=tv->model()->rowCount(QModelIndex());
        int col=tv->model()->columnCount(QModelIndex());

        out<<"\n";
        for(int i=0;i<row;i++){
            for(int j=0;j<col;j++){
                index=tv->model()->index(i,j,QModelIndex());
                out<<tv->model()->data(index).toString()<<",";
            }
            out<<"\n";
        }
        file.close();
    }
    void recipt_print(QString id,QString str,QTableView *tv,QString last){

        QString a=str;
        int sz=tv->model()->columnCount(QModelIndex());
        a+="SL\t";
        for (int i=0;i<sz;i++){
            a+=tv->model()->headerData(i,Qt::Horizontal,Qt::DisplayRole).toString()+"\t";
            if(i==0){
                a+="\t\t";
            }
        }
        a+="\n___________________________________________________________________________________________________\n";




        QModelIndex index;
        int row=tv->model()->rowCount(QModelIndex());
        int col=tv->model()->columnCount(QModelIndex());


        for(int i=0;i<row;i++){
            a+=QString::number(i+1)+"\t";
            for(int j=0;j<col;j++){
                index=tv->model()->index(i,j,QModelIndex());
                a+=tv->model()->data(index).toString()+"\t";
                if(j==0){
                    if(tv->model()->data(index).toString().length()<15){
                        a+="\t";
                    }
                }

            }
            a+="\n";
        }
        a+=last;
        QFile file(id);
        if (!file.open(QFile::ReadWrite | QFile::Text)){}
        file.seek(0);
        file.write(a.toUtf8());
        file.close();
        QDesktopServices::openUrl(id);

        QPrinter printer(QPrinter::HighResolution);
        printer.setOutputFormat(QPrinter::PdfFormat);
        printer.setOutputFileName("abcd.pdf");

        QImage img("spl_logo.png");

        QTextDocument doc;
        doc.setPlainText(a);
        doc.print(&printer);

        QTextCursor cursor(&doc);
        cursor.movePosition(QTextCursor::End);
        cursor.insertImage(img);
/*
        doc.addResource(QTextDocument::ImageResource,QUrl("spl_logo.png"), QVariant(img));
        QTextImageFormat imageFormat;
        imageFormat.setName("spl_logo.png");
        cursor.insertImage(imageFormat);


        QTextEdit parent;
        parent.setText(a);
        parent.print(&printer);
        QPainter paint;
        paint.begin(&printer);
        paint.drawImage(1,1,img);
        paint.end();*/


    }

    double max_value(QString qry,int v){
        QString str;
        QSqlQuery q;
        double max=0;
        q.prepare(qry);

        if( q.exec()){
            while(q.next()){
                str=q.value(v).toString();
                if(str.toDouble()>max){
                    max=str.toDouble();
                }
            }
        }
        else{
            QSqlError er=q.lastError();
            QString e=er.text();
            QMessageBox msg;
            msg.setText(e);
            msg.exec();

        }
        return max;
    }



};

#endif // DBSCLASS_H
