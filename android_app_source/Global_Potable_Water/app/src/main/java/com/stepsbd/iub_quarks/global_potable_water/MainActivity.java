package com.stepsbd.iub_quarks.global_potable_water;

import android.content.Intent;
import android.location.LocationManager;
import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.telephony.SmsManager;
import android.view.Menu;
import android.view.MenuItem;
import android.app.Activity;
import android.os.Bundle;
import android.widget.ImageButton;
import android.widget.Toast;
import android.view.View;
import android.view.View.OnClickListener;


public class MainActivity extends ActionBarActivity {

    ImageButton nasa_logo_img_btn; //Main Page ImageButton Logo

    private LocationManager locationManager;

    protected String latitude,longitude;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        addListenerOnButton();
    }

    public void addListenerOnButton(){

        nasa_logo_img_btn=(ImageButton) findViewById(R.id.nasa_click);
        nasa_logo_img_btn.setOnClickListener(new OnClickListener() {
            @Override
            public void onClick(View v) {
                //here
                Intent main_menu = new Intent(MainActivity.this , Main_Menu.class);
                startActivity(main_menu);
            }
        });

    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main, menu);
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
