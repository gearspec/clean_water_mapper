# clean_water_mapper
Global Clean Water Mapper (NASA Space Apps Challenge 2015)
--
Read me version 1.0
-------------------------------------------------
Hello and welcome to our Project.
This is a project we have put together in the
two days of NASA Apps Challenge 2015.
----------------------------------------------
All Sources are of GNU GPL 3.0 License
----------------------------------------------
Project Mailing List:

Android APK (Android Stduio, Java): gearspec@gmail.com
Data Visualization over Linux (QT, C++) : junaed_s@live.com
Data Visualization over Windows (MS Visual C#, .net Framework): sumon_neo@live.com

----------------------------------------------
APK Configuration for your country (SMS):
The android application uses an SMS gateway (1616) to send data.
You can edit line number 64 in 
Global_Potable_Water/app/src/main/java/com/stepsbd/iub_quarks/global_potable_water/idiv_subgroup.java

It is not necessery to have a sms gateway for data collecton. You can use any regular phone number
supported under you Network Operator.

example : Change this line

sms.sendTextMessage("1616", null,msg, null, null);

to :

sms.sendTextMessage("01711027026", null,msg, null, null);

Changing the sent data
-----------------------------------------------------
SMS Format: 
String msg ="WP gs 2,"+gps+","+water_source_str+","+water_source_str+","+source_sub;

-----------------------------------------------------
For the Visualization Tools , Use QT 4.8 for Linux Based Systems.
Use Windows (x86/x64), Visual Studio for Windows Based Systems.

Data Visualization tools require MySQL and Apache Server Running on your Operating System.
Place everything from : https://github.com/gearspec/clean_water_mapper/tree/master/apache_web_php/Apache2%20codes
to your Apache htdocs , var/www and start the server.
It collects submiited data from http://wsms.adpers.net/retreive.php
and uses it locally for Visualization. 

------------------------------------------------------
We plan on bringing the application to Windows Phone, Sailfish OS, iOS as well.
Fork it and experiment as you wish.
----------------------------------------------------------
For feature Request and Bug Report , Please see our mailing list.

For our other projects, check out
http://www.stepsbd.com/home/research-free-stuff/
http://ultradefrag.sourceforge.net/en/index.html?about
