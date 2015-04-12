#ifndef WIDGET_H
#define WIDGET_H

#include <QWidget>
#include <QFile>
#include <QFileDialog>
#include<QTextStream>
#include<QMessageBox>
#include<QStandardItem>
#include<dbsclass.h>
#include<form_map.h>
#include<QtWebKit>

namespace Ui {
class Widget;
}

class Widget : public QWidget
{
    Q_OBJECT
    
public:
    explicit Widget(QWidget *parent = 0);
    ~Widget();
    QStringList header_value;
    QStringList new_data;
    
private slots:
    void on_btn_upload_clicked();

    void on_btn_setup_clicked();

    void on_btn_create_clicked();

    void on_btn_insert_clicked();

    void on_btn_test_clicked();

    void on_btn_exp_csv_clicked();

    void on_btn_marge_clicked();

    void on_btn_uload_clicked();

private slots:
    void refress();
    void on_btn_Map_clicked();

    void on_tbx_search_dbs_textChanged(const QString &arg1);

    void on_tbx_search_csv_textChanged(const QString &arg1);

private:
    Ui::Widget *ui;
};

#endif // WIDGET_H
