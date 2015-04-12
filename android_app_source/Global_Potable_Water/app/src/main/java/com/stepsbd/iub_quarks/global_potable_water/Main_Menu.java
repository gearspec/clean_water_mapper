package com.stepsbd.iub_quarks.global_potable_water;

import android.content.Intent;
import android.support.v7.app.ActionBarActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.Button;
import android.view.View.OnClickListener;


public class Main_Menu extends ActionBarActivity{

    Button new_menu2;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main__menu);

        addListenerOnButton();
    }


    public void addListenerOnButton() {

        new_menu2=(Button) findViewById(R.id.clean_water_info);

        new_menu2.setOnClickListener(new OnClickListener() {

            @Override
            public void onClick(View arg0) {

                Intent intent2=new Intent(getApplicationContext(), location_sys.class);
                intent2.putExtra("menu_no", "M-2");
                startActivity(intent2);
            }

        });

    }


    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        // Inflate the menu; this adds items to the action bar if it is present.
        getMenuInflater().inflate(R.menu.menu_main__menu, menu);
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
