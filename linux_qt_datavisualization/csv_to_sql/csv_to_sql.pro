#-------------------------------------------------
#
# Project created by QtCreator 2015-04-08T00:02:14
#
#-------------------------------------------------

QT       += core gui sql webkit

greaterThan(QT_MAJOR_VERSION, 4): QT += widgets

TARGET = csv_to_sql
TEMPLATE = app


SOURCES += main.cpp\
        widget.cpp \
    dbsclass.cpp \
    form_map.cpp

HEADERS  += widget.h \
    dbsclass.h \
    form_map.h

FORMS    += widget.ui \
    form_map.ui
