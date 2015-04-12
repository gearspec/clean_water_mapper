package com.stepsbd.iub_quarks.global_potable_water;

import android.content.Intent;
import android.net.Uri;
import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.telephony.SmsManager;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

import java.util.ArrayList;
import java.util.List;


public class idiv_subgroup extends ActionBarActivity {

    String menu_no_str;
    String water_source_str;
    String gps;

    TextView text1;
    TextView text2;
    TextView text3;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_idiv_subgroup);

        menu_no_str= getIntent().getStringExtra("menu_no");
        water_source_str= getIntent().getStringExtra("water_source");
        gps= getIntent().getStringExtra("gps");

        text1 =(TextView) findViewById(R.id.textView4);
        text2 =(TextView) findViewById(R.id.textView5);
        text3 =(TextView) findViewById(R.id.textView6);

        text1.setText(menu_no_str);
        text2.setText(water_source_str);
        text3.setText(gps);

        addItemsOnSpinner3();

    }

    public void messageSend(View v)
    {
        //TextView water_source = (TextView) findViewById(R.id.textView5);
        //TextView gps_txtv = (TextView) findViewById(R.id.textView6);

        Spinner spin_source=(Spinner) findViewById(R.id.spinnerBox);
        String source_sub = spin_source.getSelectedItem().toString();
        //gps="23.745-90.5125"; //Junaed

        SmsManager sms = SmsManager.getDefault();
        //String msg ="2,"+gps+","+text2.getText().toString()+","+source_type;
        String msg ="WP gs 2,"+gps+","+water_source_str+","+water_source_str+","+source_sub;
        sms.sendTextMessage("1616", null,msg, null, null);
        Toast.makeText(getApplicationContext(), "Thank You for your Submission", Toast.LENGTH_LONG).show();
    }

    public void addItemsOnSpinner3() {

        Spinner spinner2 = (Spinner) findViewById(R.id.spinnerBox);
        List<String> list = new ArrayList<String>();

        String wr =text2.getText().toString();
        //Toast.makeText(getApplicationContext(), wr, Toast.LENGTH_SHORT).show();

        if (wr.equals("Ground Water (Well, Deep Tube Well)")){
            //Toast.makeText(getApplicationContext(), "msg msg", Toast.LENGTH_SHORT).show();
            list.add("Well");
            list.add("Deep Tube Well");
        }
        else if(wr.equals("Surface Water (River, Stream, Fountain)")){
            list.add("River");
            list.add("Stream");
            list.add("Fountain");
        }
        else if (wr.equals("Tap Water (Water Network)")){
            list.add("Residential Network");
        }
        ////--------
        else if (wr.equals("Biological (Plants)")){
            list.add("Plant-Water");
        }
        else if (wr.equals("Precipitation (Rain, Hail, Snow)")){
            list.add("Rain");
            list.add("Hail");
            list.add("Snow");
        }
        else if (wr.equals("DeSalinated (SeaWater)")){
            list.add("Sea Water");
        }
        else{}

        ArrayAdapter<String> dataAdapter = new ArrayAdapter<String>(this,android.R.layout.simple_spinner_item, list);
        dataAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        spinner2.setAdapter(dataAdapter);
    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_idiv_subgroup, menu);
        return true;
    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        // Handle action bar item clicks here. The action bar will
        // automatically handle clicks on the Home/Up button, so long
        // as you specify a parent activity in AndroidManifest.xml.
        int id = item.getItemId();

        //noinspection SimplifiableIfStatement
        if (id == R.id.action_settings) {
            return true;
        }

        return super.onOptionsItemSelected(item);
    }

}
