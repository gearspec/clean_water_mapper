package com.stepsbd.iub_quarks.global_potable_water;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.location.Criteria;
import android.location.Location;
import android.location.LocationListener;
import android.location.LocationManager;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;
import android.widget.ArrayAdapter;
import java.util.ArrayList;
import java.util.List;

import java.util.ArrayList;
import java.util.List;

public class location_sys extends Activity implements LocationListener {

    private TextView latituteField;
    private TextView longitudeField;
    private LocationManager locationManager;
    private String provider;


    /** Called when the activity is first created. */

    @Override
    public void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.gps_page);


        addItemsOnSpinner2();
        addListenerOnSpinnerItemSelection();
        // Capture our button from layout
        Button btn_individual = (Button)findViewById(R.id.btn_submit_individual);



        latituteField = (TextView) findViewById(R.id.txtlat);
        longitudeField = (TextView) findViewById(R.id.txtlng);
        TextView txtmenu=(TextView) findViewById(R.id.textView_menu);


        String value= getIntent().getStringExtra("menu_no");

        //if(value=="M-2"){
            txtmenu.setText(value);

        //}


        // Get the location manager
        locationManager = (LocationManager) getSystemService(Context.LOCATION_SERVICE);
        // Define the criteria how to select the locatioin provider -> use
        // default
        Criteria criteria = new Criteria();
        provider = locationManager.getBestProvider(criteria, false);
        Location location = locationManager.getLastKnownLocation(provider);

        // Initialize the location fields
        if (location != null) {
            System.out.println("Provider " + provider + " has been selected.");
            onLocationChanged(location);
        } else {
            latituteField.setText("N/A");
            longitudeField.setText("N/A");
        }
    }

    public void showNewDate(View v)
    {
        //Spinner spin_source=(Spinner) findViewById(R.id.spi)

        Spinner mySpinner=(Spinner) findViewById(R.id.water_source_ui);
        String source_type = mySpinner.getSelectedItem().toString();

        TextView latituteField = (TextView) findViewById(R.id.txtlat);
        TextView longitudeField = (TextView) findViewById(R.id.txtlng);

        String gps =latituteField.getText().toString()+"-"+longitudeField.getText().toString();

        Intent intent2=new Intent(getApplicationContext(), idiv_subgroup.class);
        intent2.putExtra("menu_no", "M-2");
        intent2.putExtra("water_source", source_type);
        intent2.putExtra("gps",gps);
        startActivity(intent2);
        Toast.makeText(getApplicationContext(), "Open Public Submission", Toast.LENGTH_SHORT).show();
    }

    public void addItemsOnSpinner2() {

        Spinner spinner2 = (Spinner) findViewById(R.id.water_source_ui);
        List<String> list = new ArrayList<String>();
        list.add("Surface Water (River, Stream, Fountain)");
        list.add("Ground Water (Well, Deep Tube Well)");
        list.add("Tap Water (Water Network)");
        list.add("Biological (Plants)");
        list.add("Precipitation (Rain, Hail, Snow)");
        list.add("DeSalinated (SeaWater)");

        ArrayAdapter<String> dataAdapter = new ArrayAdapter<String>(this,android.R.layout.simple_spinner_item, list);
        dataAdapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);
        spinner2.setAdapter(dataAdapter);
    }


    public void addListenerOnSpinnerItemSelection() {
        Spinner spinner1 = (Spinner) findViewById(R.id.water_source_ui);
        //spinner1.setOnItemSelectedListener(new CustomOnItemSelectedListener());
    }

    /* Request updates at startup */
    @Override
    protected void onResume() {
        super.onResume();
        locationManager.requestLocationUpdates(provider, 400, 1, this);
    }

    /* Remove the locationlistener updates when Activity is paused */
    @Override
    protected void onPause() {
        super.onPause();
        locationManager.removeUpdates(this);
    }

    @Override
    public void onLocationChanged(Location location) {
        float lat = (float) (location.getLatitude());
        float lng = (float) (location.getLongitude());
        latituteField.setText(String.valueOf(lat));
        longitudeField.setText(String.valueOf(lng));
    }

    @Override
    public void onStatusChanged(String provider, int status, Bundle extras) {
        // TODO Auto-generated method stub

    }

    @Override
    public void onProviderEnabled(String provider) {
        Toast.makeText(this, "Enabled new provider " + provider,
                Toast.LENGTH_SHORT).show();

    }

    @Override
    public void onProviderDisabled(String provider) {
        Toast.makeText(this, "Disabled provider " + provider,
                Toast.LENGTH_SHORT).show();
    }
}

