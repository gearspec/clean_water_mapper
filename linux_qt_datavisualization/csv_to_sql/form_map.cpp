#include "form_map.h"
#include "ui_form_map.h"

form_map::form_map(QWidget *parent) :
    QWidget(parent),
    ui(new Ui::form_map)
{
    ui->setupUi(this);

    QPixmap bkgnd("bg2.png");
    bkgnd = bkgnd.scaled(this->size(), Qt::IgnoreAspectRatio);
    QPalette palette;
    palette.setBrush(QPalette::Background, bkgnd);
    this->setPalette(palette);

    ui->btn_load->click();

    QTimer *t=new QTimer(this);
    connect(t,SIGNAL(timeout()),this,SLOT(refress()));
    t->start(10000);
}

form_map::~form_map()
{
    delete ui;
}

void form_map::refress()
{

}

void form_map::on_btn_load_clicked()
{
    QString google="localhost/map.html";
    ui->web_View->load("http://"+google);

    dbsclass dbs;

    QString q_output="select * from `"+ui->tbx_schema->text()+"`.`"+ui->tbx_table_name->text()+"`";
    dbs.tv_display(ui->tv_map,q_output);
}


void form_map::on_btn_goback_clicked()
{
    Widget *w=new Widget;
    w->show();
    this->hide();
}

void form_map::on_tbx_search_csv_textChanged(const QString &arg1)
{
    dbsclass dbs;
    dbs.search_tv(arg1,ui->tv_map);
}
