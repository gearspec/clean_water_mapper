#include "dbsclass.h"


dbsclass::dbsclass()
{
    //conn_close();
}
void dbsclass::tv_display(QTableView *qtv,QString q){

    QSqlQueryModel *m=new QSqlQueryModel;
    QSqlQuery qry;
    qry.prepare(q);
    if( qry.exec()){
        m->setQuery(qry);
        qtv->setModel(m);
        //qtv->model()->startTimer(500);
       // qtv->model()->killTimer(0);
    }
    else{
        QSqlError er=qry.lastError();
        QString e=er.text();
        QMessageBox msg;
        msg.setText(e);
        msg.exec();

    }

}
void dbsclass::fill_combo(QFontComboBox *ctbx,QString qry){

        QSqlQueryModel *m=new QSqlQueryModel;
        QSqlQuery q;
        q.prepare(qry);


        if( q.exec()){
            m->setQuery(q);
            ctbx->clear();
            ctbx->setModel(m);
        }
        else{
            QSqlError er=q.lastError();
            QString e=er.text();
            QMessageBox msg;
            msg.setText(e);
            msg.exec();

        }
        ctbx->setCurrentIndex(-1);
}
void dbsclass::fill_combobox(QComboBox *ctbx,QString qry){

        QSqlQueryModel *m=new QSqlQueryModel;
        QSqlQuery q;
        q.prepare(qry);

        if( q.exec()){
            m->setQuery(q);
            ctbx->clear();
            ctbx->setModel(m);
        }
        else{
            QSqlError er=q.lastError();
            QString e=er.text();
            QMessageBox msg;
            msg.setText(e);
            msg.exec();

        }
        ctbx->setCurrentIndex(-1);
}

//overloading fonuction append "ALL" on top
void dbsclass::fill_combobox(QComboBox *ctbx,QString qry,int v){


   // double x=tbl_sz(qry);
    //QString a="";
    QStringList ls;
    ls.append("ALL");
    QSqlQuery q;
    q.prepare(qry);
    //int i=0;

    if( q.exec()){
        while(q.next()){
            //a+=q.value(v).toString()+",";
            ls.append(q.value(v).toString());
        }
    }
    else{
        QSqlError er=q.lastError();
        QString e=er.text();
        QMessageBox msg;
        msg.setText(e);
        msg.exec();

    }
    ctbx->setModel(new QStringListModel(ls));
}


void dbsclass::fill_tbx(QLineEdit *tbx,QString qry,int v){
    QSqlQueryModel *m=new QSqlQueryModel;
    QSqlQuery q;
    q.prepare(qry);


    if( q.exec()){
        m->setQuery(q);
        while(q.next()){
            tbx->setText(q.value(v).toString());
        }
    }
    else{
        QSqlError er=q.lastError();
        QString e=er.text();
        QMessageBox msg;
        msg.setText(e);
        msg.exec();

    }
}
QString dbsclass::fill_string(QString qry,int v){
    QString str;
    QSqlQuery q;
    q.prepare(qry);

    if( q.exec()){
        while(q.next()){
            str=q.value(v).toString();
        }
    }
    else{
        QSqlError er=q.lastError();
        QString e=er.text();
        QMessageBox msg;
        msg.setText(e);
        msg.exec();

    }
    return str;
}
QByteArray dbsclass::fill_blob(QString qry,int v){
    QByteArray str;
    QSqlQuery q;
    q.prepare(qry);

    if( q.exec()){
        while(q.next()){
            str=q.value(v).toByteArray();
        }
    }
    else{
        QSqlError er=q.lastError();
        QString e=er.text();
        QMessageBox msg;
        msg.setText(e);
        msg.exec();

    }
    return str;
}
void dbsclass::fill_label(QLabel *lbl,QString qry,int v){
    QSqlQuery q;
    q.prepare(qry);

    if( q.exec()){
        while(q.next()){
            lbl->setText(q.value(v).toString());
        }
    }
    else{
        QSqlError er=q.lastError();
        QString e=er.text();
        QMessageBox msg;
        msg.setText(e);
        msg.exec();

    }
}
double dbsclass::fill_array(QString qry,int v){

    double x=0;
    QSqlQuery q;
    q.prepare(qry);


    if( q.exec()){
        while(q.next()){
            x+=q.value(v).toDouble();
        }
    }
    else{
        QSqlError er=q.lastError();
        QString e=er.text();
        QMessageBox msg;
        msg.setText(e);
        msg.exec();

    }
    return x;
}
int dbsclass::tbl_sz(QString qry){
    int str=0;

    QSqlQuery q;
    q.prepare(qry);

    if( q.exec()){
        while(q.next()){
            str++;
        }
    }
    else{
        QSqlError er=q.lastError();
        QString e=er.text();
        QMessageBox msg;
        msg.setText(e);
        msg.exec();

    }
    return str;
}
bool dbsclass::chkpass(QString qry){
    int str=0;

    QSqlQuery q;
    q.prepare(qry);


    if( q.exec()){
        while(q.next()){
            str++;
        }
    }
    else{
        QSqlError er=q.lastError();
        QString e=er.text();
        QMessageBox msg;
        msg.setText(e);
        msg.exec();

    }

    if(str==0){
        return false;
    }
    else{
        return true;
    }



}

QString dbsclass::fill_array_string(QString qry,int v){


   // double x=tbl_sz(qry);
    QString a="";
    QSqlQuery q;
    q.prepare(qry);
    //int i=0;

    if( q.exec()){
        while(q.next()){
            a+=q.value(v).toString()+",";
        }
    }
    else{
        QSqlError er=q.lastError();
        QString e=er.text();
        QMessageBox msg;
        msg.setText(e);
        msg.exec();

    }
    return a;
}
