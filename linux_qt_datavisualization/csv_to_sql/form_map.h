#ifndef FORM_MAP_H
#define FORM_MAP_H

#include<QtWebKit>
#include <QWidget>
#include<QMessageBox>
#include<QDesktopWidget>
#include<QComboBox>
#include<QProgressBar>
#include<dbsclass.h>
#include<widget.h>

namespace Ui {
class form_map;
}

class form_map : public QWidget
{
    Q_OBJECT
    
public:
    explicit form_map(QWidget *parent = 0);
    ~form_map();
    
private slots:
    void refress();

    void on_btn_load_clicked();

    void on_btn_goback_clicked();

    void on_tbx_search_csv_textChanged(const QString &arg1);

private:
    Ui::form_map *ui;
};

#endif // FORM_MAP_H
