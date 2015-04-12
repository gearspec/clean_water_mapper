using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace nasa
{
    public partial class Dashbord : MetroForm
    {

        string text;
        Int64 temp_lenght;
        Int64 temp_lenght2;
        private readonly Timer _timer = new Timer();
       
        public Dashbord()
        {
            InitializeComponent();


            _timer.Interval = 60000;
            _timer.Tick += TimerTick;
            _timer.Enabled = true;

        }

        dbs ds = new dbs();
        int count_dgv_rows = 0;
        string gps;
        string main_data;
        string[] individual_data = new string[100];
        private void Dashbord_Load(object sender, EventArgs e)
        {
            ds.DgvDisplay("select gps as GPS, water_source as WaterSource, type_of_source as Type,test_category as TestName from water_map.user_input", dgv_dataset);
            webBrowser2.Navigate("localhost/map.html");
            webBrowser2.ScriptErrorsSuppressed = true;
            text = File.ReadAllText("E:/UniServerZ/www/test.txt");

            temp_lenght = text.Length;
            temp_lenght2 = text.Length;

        }

        void TimerTick(object sender, EventArgs e)
        {
            webBrowser3.Refresh();

            webBrowser2.Refresh();
          /*  temp_lenght = File.ReadAllText("E:/UniServerZ/www/test.txt").Length;
            
           // count_dgv_rows = dgv_dataset.Rows.Count;
           // MessageBox.Show("a"+temp_lenght.ToString());
            //MessageBox.Show("b"+temp_lenght2.ToString());
          //  ds.DgvDisplay("select gps as GPS, water_source as WaterSource, type_of_source as Type,test_category as TestName from water_map.user_input", dgv_dataset);
            if (temp_lenght!=temp_lenght2)
            {
               // MessageBox.Show("changed");
                webBrowser2.Navigate("localhost/map.html");
                webBrowser2.ScriptErrorsSuppressed = true;
                temp_lenght2 = temp_lenght;
       
            }

          */
         //   webBrowser3.Navigate("localhost");
               
        }
       
        private void dgv_dataset_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_dataset_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgv_dataset_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView row = sender as DataGridView;
            if (row != null)
            {
                DataGridViewCell selectedcell = row.SelectedCells[0];
                gps = selectedcell.Value.ToString();
                gps = gps.Replace("-", ",");
                webBrowser1.Navigate("http://www.maps.google.com?q=" + gps);
                webBrowser1.ScriptErrorsSuppressed = true;
                //MessageBox.Show(selectedcell.Value.ToString());
                main_data = ds.GetStringFromDbs("select test_data from water_map.user_input where gps='"+selectedcell.Value.ToString()+"'", "test_data");
                //MessageBox.Show(main_data);
                individual_data = main_data.Split('-');
                foreach (string item in individual_data)
                {
                   // richTextBox1.Text += item + Environment.NewLine;
                }



                string[] name_elements = new string[10];
                Double[] value_elements = new Double[10];

                
                Double[] value_elements_fake = new Double[10];



                name_elements[0] = "Bacteria";
                name_elements[1] = "Nitrogen";
                name_elements[2] = "Iron";
               // name_elements[3] = "CaCo3";

                value_elements[0] = 0.05;
                value_elements[1] = 4.88;
                value_elements[2] = 0.55;
               // value_elements[3] = 200;
                value_elements_fake[0] = 0.70;
                value_elements_fake[1] = 3.88;
                value_elements_fake[2] = 1.55;
               

                chart_pie_standard.Visible = true;
                chart_pie_actual_data.Visible = true;
                ds.chart_pie_custom(chart_pie_standard, "ChartView", name_elements, value_elements);
                ds.chart_pie_custom(chart_pie_actual_data, "ChartView", name_elements, value_elements_fake);

            }
            metroTabControl1.SelectedIndex = 1;
        }

        private void chart_bar_policy_Click(object sender, EventArgs e)
        {

        }
    }
}
