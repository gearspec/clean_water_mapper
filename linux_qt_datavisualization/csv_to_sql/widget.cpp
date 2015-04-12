#include "widget.h"
#include "ui_widget.h"

Widget::Widget(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::Widget)
{
    ui->setupUi(this);

    QPixmap bkgnd("bg2.png");
    bkgnd = bkgnd.scaled(this->size(), Qt::IgnoreAspectRatio);
    QPalette palette;
    palette.setBrush(QPalette::Background, bkgnd);
    this->setPalette(palette);


    ui->progressBar->setValue(0);
    ui->progressBar->setHidden(true);
    ui->btn_setup->click();

    dbsclass dbs;
    QString q_output="select * from `"+ui->tbx_schema->text()+"`.`"+ui->tbx_table_name->text()+"`";
    dbs.tv_display(ui->tv_output,q_output);


    QString google="localhost/map.html";
    ui->web_View->load("http://"+google);
}

Widget::~Widget()
{
    delete ui;
}

void Widget::on_btn_upload_clicked()
{
    QString filePath,full,temp;
    QStringList full_lst;
    QStandardItemModel *mod = new QStandardItemModel;

    filePath=QFileDialog::getOpenFileName(this,tr("Open File"), QDir::currentPath());
    ui->tbx_tech->setText(filePath);
    QFile f_read(filePath);
    if (!f_read.open(QFile::ReadOnly | QFile::Text)){}
    QTextStream in(&f_read);
    full = in.readAll();
    f_read.close();
    full_lst=full.split("\n");
    QMessageBox msb;
    msb.setText(full_lst.value(0));
    //msb.exec();

    msb.setText(full_lst.value(1));
    //msb.exec();

    for(int i=0;i<full_lst.length()-1;i++){
        temp=full_lst.value(i);
        QStringList r_value=temp.split(",");
        if(i==0){
            header_value=r_value;
            for(int j=0;j<r_value.length();j++){
                QStandardItem *header=new QStandardItem(QString(r_value.value(j)));
                mod->setHorizontalHeaderItem(j,header);
            }
        }
        else{
            for(int j=0;j<r_value.length();j++){
                QStandardItem *itm = new QStandardItem(QString(r_value.value(j)));
                mod->setItem(i-1,j,itm);
            }
        }

    }
    ui->tv_csv_table->setModel(mod);

}

void Widget::on_btn_setup_clicked()
{
    QString repl=ui->tbx_host->text()+","+ui->tbx_db_name->text()+","+ui->tbx_db_user->text()+","+ui->tbx_db_pass->text()+","+ui->tbx_port->text();

    QFile file("server_conn.txt");
    if (!file.open(QFile::ReadWrite | QFile::Text)){}
    file.seek(0);
    file.write(repl.toUtf8());
    file.close();

    // QFile file("server_conn.txt");
    if (!file.open(QFile::ReadOnly | QFile::Text)){}
    QTextStream in(&file);
    QString temp = in.readAll();
    QStringList lst=temp.split(",");
    file.close();

    dbsclass dbs;
    dbs.conn(lst);

    QTimer *t=new QTimer(this);
    connect(t,SIGNAL(timeout()),this,SLOT(refress()));
    t->start(1000);
}

void Widget::on_btn_create_clicked()
{
    ui->progressBar->setValue(0);

    dbsclass dbs;

    //QString colunm,prev_column;

    QString q_create_schema="CREATE SCHEMA `"+ui->tbx_schema->text()+"` ";
    dbs.queryfeeder(q_create_schema);

    QString q_create_table="CREATE TABLE `"+ui->tbx_schema->text()+"`.`"+ui->tbx_table_name->text()+"`(`"+header_value.value(0)+"`  VARCHAR(80) NULL) ";
    dbs.queryfeeder(q_create_table);

    QString q_alter_table;
    for(int i=1;i<header_value.length();i++){
        q_alter_table="ALTER TABLE `"+ui->tbx_schema->text()+"`.`"+ui->tbx_table_name->text()+"` ADD COLUMN `"+header_value.value(i)+"` VARCHAR(80) NULL AFTER `"+header_value.value(i-1)+"`";
        dbs.queryfeeder(q_alter_table);
    }


    ui->progressBar->setHidden(false);
    QString q_insert_statement;
    QModelIndex ind;
    int sz=ui->tv_csv_table->model()->rowCount(QModelIndex());
    for(int i=0;i<sz;i++){
        q_insert_statement="INSERT INTO `"+ui->tbx_schema->text()+"`.`"+ui->tbx_table_name->text()+"` (";
        q_insert_statement+="`"+header_value.value(0)+"`";
        for(int j=1;j<header_value.length();j++){
            q_insert_statement+=",`"+header_value.value(j)+"`";
        }
        q_insert_statement+=") VALUES(";

        ind=ui->tv_csv_table->model()->index(i,0,QModelIndex());
        q_insert_statement+="'"+ui->tv_csv_table->model()->data(ind).toString()+"'";
        for(int j=1;j<header_value.length();j++){
            ind=ui->tv_csv_table->model()->index(i,j,QModelIndex());
            q_insert_statement+=",'"+ui->tv_csv_table->model()->data(ind).toString()+"'";
        }
        q_insert_statement+=")";
        dbs.queryfeeder(q_insert_statement);
        ui->progressBar->setValue((i*100)/sz);
    }
    ui->progressBar->setValue(100);
    QMessageBox msb;
    msb.setText("Done");
    msb.exec();
    ui->progressBar->setValue(0);
    ui->progressBar->setHidden(true);

    QString q_output="select * from `"+ui->tbx_schema->text()+"`.`"+ui->tbx_table_name->text()+"`";
    dbs.tv_display(ui->tv_output,q_output);
}

void Widget::on_btn_insert_clicked()
{
    ui->progressBar->setValue(0);


    dbsclass dbs;

    QString q_insert_statement;
    QModelIndex ind;
    int sz=ui->tv_csv_table->model()->rowCount(QModelIndex());
    for(int i=0;i<sz;i++){
        q_insert_statement="INSERT INTO `"+ui->tbx_schema->text()+"`.`"+ui->tbx_table_name->text()+"` (";
        q_insert_statement+="`"+header_value.value(0)+"`";
        for(int j=1;j<header_value.length();j++){
            q_insert_statement+=",`"+header_value.value(j)+"`";
        }
        q_insert_statement+=") VALUES(";

        ind=ui->tv_csv_table->model()->index(i,0,QModelIndex());
        q_insert_statement+="'"+ui->tv_csv_table->model()->data(ind).toString()+"'";
        for(int j=1;j<header_value.length();j++){
            ind=ui->tv_csv_table->model()->index(i,j,QModelIndex());
            q_insert_statement+=",'"+ui->tv_csv_table->model()->data(ind).toString()+"'";
        }
        q_insert_statement+=")";
        dbs.queryfeeder(q_insert_statement);
        ui->progressBar->setValue((i*100)/sz);
    }
    ui->progressBar->setValue(100);
    QMessageBox msb;
    msb.setText("Done");
    msb.exec();
    ui->progressBar->setValue(0);

    QString q_output="select * from `"+ui->tbx_schema->text()+"`.`"+ui->tbx_table_name->text()+"`";
    dbs.tv_display(ui->tv_output,q_output);
}

void Widget::on_btn_test_clicked()
{

    dbsclass dbs;
    QString q_output="select * from `"+ui->tbx_schema->text()+"`.`"+ui->tbx_table_name->text()+"`";
    dbs.tv_display(ui->tv_output,q_output);

    //dbsclass dbs;
    //QString q_exp="shell > mysqldump --databases c > file.sql";
    //dbs.queryfeeder(q_exp);
    //system("mysqldump -u root -p root c.db > some1.sql");
}

void Widget::on_btn_exp_csv_clicked()
{
    dbsclass dbs;
    dbs.csv_exp("",ui->tv_output);
}

void Widget::on_btn_marge_clicked()
{

}

void Widget::on_btn_uload_clicked()
{
    QString full,temp;
    QStringList full_lst;
    QStandardItemModel *mod = new QStandardItemModel;

    QFile f_read(ui->tbx_tech->text());
    if (!f_read.open(QFile::ReadOnly | QFile::Text)){}
    QTextStream in(&f_read);
    full = in.readAll();
    f_read.close();
    full_lst=full.split("\n");
    QMessageBox msb;
    msb.setText(full_lst.value(0));
    //msb.exec();

    msb.setText(full_lst.value(1));
    //msb.exec();
    QString h_val="submission_type, gps, water_source_type, water_source, type_of_source, test_category, test_data";
    QStringList hh=h_val.split(",");
    for(int i=0;i<full_lst.length()-1;i++){
        temp=full_lst.value(i);
        QStringList r_value=temp.split(",");
        if(i==0){
            header_value=r_value;
            for(int j=0;j<hh.length();j++){
                QStandardItem *header=new QStandardItem(QString(hh.value(j)));
                mod->setHorizontalHeaderItem(j,header);
            }

            for(int j=0;j<r_value.length();j++){
                QStandardItem *itm = new QStandardItem(QString(r_value.value(j)));
                mod->setItem(i,j,itm);
            }
        }
        else{
            for(int j=0;j<r_value.length();j++){
                QStandardItem *itm = new QStandardItem(QString(r_value.value(j)));
                mod->setItem(i,j,itm);
            }
        }

    }
    ui->tv_csv_table->setModel(mod);
}

void Widget::refress()
{
    ui->btn_uload->click();

    /*
    QModelIndex ind;
    QString temp="";
    for(int i=0;i<ui->tv_csv_table->model()->columnCount();i++){
        ind=ui->tv_csv_table->model()->index(0,i,QModelIndex());
        temp+=ui->tv_csv_table->model()->data(ind).toString();
    }
    QStringList t_l=temp.split(",");
    bool b=true;
    for(int i=0;i<ui->tv_csv_table->model()->columnCount();i++){
        if(t_l.value(i)!=new_data.value(i)){
            b=true;
        }
    }
    if(b==true){
        new_data.clear();
        for(int i=ui->tv_csv_table->model()->columnCount()-1;i<=0;i++){
           new_data.append(t_l.value(i));
        }


    }*/

    QModelIndex ind2;

    int sz_add=ui->tv_csv_table->model()->rowCount()-ui->tv_output->model()->rowCount();
    if(sz_add>0){
        QString temp;
        //QStringList full_lst;
        QStandardItemModel *mod = new QStandardItemModel;
        QString h_val="submission_type,gps,water_source_type,water_source,type_of_source,test_category,test_data";
        QStringList hh=h_val.split(",");
        for(int j=0;j<ui->tv_csv_table->model()->columnCount();j++){

            QStandardItem *header=new QStandardItem(QString(hh.value(j)));
            mod->setHorizontalHeaderItem(j,header);
        }

        for(int i=0;i<sz_add;i++){
            for(int j=0;j<ui->tv_csv_table->model()->columnCount();j++){
                ind2=ui->tv_csv_table->model()->index(i,j,QModelIndex());
                temp=ui->tv_csv_table->model()->data(ind2).toString();
                QStandardItem *itm = new QStandardItem(QString(temp));
                mod->setItem(i,j,itm);
            }


        }
        QString google="localhost/map.html";
        ui->web_View->load("http://"+google);
        ui->tv_csv_table->setModel(mod);ui->progressBar->setValue(0);


        dbsclass dbs;



        QString q_insert_statement;
        QModelIndex ind;
        int sz=ui->tv_csv_table->model()->rowCount(QModelIndex());
        for(int i=0;i<sz;i++){
            q_insert_statement="INSERT INTO `"+ui->tbx_schema->text()+"`.`"+ui->tbx_table_name->text()+"` (";
            q_insert_statement+="`"+hh.value(0)+"`";
            for(int j=1;j<hh.length();j++){
                q_insert_statement+=",`"+hh.value(j)+"`";
            }
            q_insert_statement+=") VALUES(";

            ind=ui->tv_csv_table->model()->index(i,0,QModelIndex());
            q_insert_statement+="'"+ui->tv_csv_table->model()->data(ind).toString()+"'";
            for(int j=1;j<hh.length();j++){
                ind=ui->tv_csv_table->model()->index(i,j,QModelIndex());
                q_insert_statement+=",'"+ui->tv_csv_table->model()->data(ind).toString()+"'";
            }
            q_insert_statement+=")";
            dbs.queryfeeder(q_insert_statement);
            ui->progressBar->setValue((i*100)/sz);
        }
        ui->progressBar->setValue(100);
        QMessageBox msb;
        msb.setText("New ("+QString::number(sz_add)+") Data Submited");
        msb.exec();
        ui->progressBar->setValue(0);

        QString q_output="select * from `"+ui->tbx_schema->text()+"`.`"+ui->tbx_table_name->text()+"`";
        dbs.tv_display(ui->tv_output,q_output);
    }



}

void Widget::on_btn_Map_clicked()
{
    form_map *m=new form_map;
    m->show();
    this->hide();
}

void Widget::on_tbx_search_dbs_textChanged(const QString &arg1)
{
    dbsclass dbs;
    dbs.search_tv(arg1,ui->tv_output);
}

void Widget::on_tbx_search_csv_textChanged(const QString &arg1)
{
    dbsclass dbs;
    dbs.search_tv(arg1,ui->tv_csv_table);
}
