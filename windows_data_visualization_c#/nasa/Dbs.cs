using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Windows.Forms.DataVisualization.Charting;

namespace nasa
{
    class dbs
    {


        //declaring database variables START
        MySqlConnection connection;
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
        DataTable table;
        BindingSource bs;
        public static string style_id;
        //declaring database variables END

        //----------------------------------------------------------------------------

        // function connect database START


        void dbs_connection()
        {
            string connect_string = "datasource=localhost;port=3306;username=root;password=root;";//sslmode=Required";
            connection = new MySqlConnection(connect_string);
        }

        // function connect database END

        //----------------------------------------------------------------------------


        // function for insert,update,delete,read START.
        public void QueryFeeder(string query)
        {
            try
            {
                dbs_connection();
                cmd = new MySqlCommand(query, connection);
                connection.Open();
                reader = cmd.ExecuteReader();
                reader.Close();
                connection.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        // function for insert,update,delete,read END.


        //----------------------------------------------------------------------------


        // function for datagridview display START.

        public void DgvDisplay(string query, DataGridView dgvno)
        {
            try
            {
                dbs_connection();
                cmd = new MySqlCommand(query, connection);
                connection.Open();
                adapter = new MySqlDataAdapter();
                adapter.SelectCommand = cmd;
                table = new DataTable();
                adapter.Fill(table);
                bs = new BindingSource();
                bs.DataSource = table;
                dgvno.DataSource = bs;
                adapter.Update(table);
                connection.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        // function for datagridview display END.


        //----------------------------------------------------------------------------

        // function for loginform/id password check START.

        public bool IdPasswordChk(string query)
        {

            try
            {
                dbs_connection();
                cmd = new MySqlCommand(query, connection);
                connection.Open();
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    reader.Close();
                    connection.Close();
                    return true;
                }

                else
                {
                    reader.Close();
                    connection.Close();
                    return false;

                }

            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }


        }


        // function for loginform/id password check END .

        //----------------------------------------------------------------------------

        //count

        public int count_return_rows(string query)
        {
            int counter = 0;
            try
            {
                dbs_connection();
                cmd = new MySqlCommand(query, connection);
                connection.Open();
                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    counter++;
                }

                reader.Close();
                connection.Close();
                return counter;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        //




        // function for fill combox START.
        public void FillCombo(string query, string column, ComboBox combo)
        {
            combo.Items.Clear();
            try
            {
                dbs_connection();
                cmd = new MySqlCommand(query, connection);
                connection.Open();
                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    string item = reader.GetString(column);
                    combo.Items.Add(item);
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        // function for fill combox END







        public void GetValuesToArray(string query, string[] name1, string col1, string[] name2, string col2, string[] name3, string col3, string[] name4, string col4, string[] name5, string col5, string[] name6, string col6, string[] name7, string col7, string[] name8, string col8, ref int count)
        {


            try
            {
                dbs_connection();
                cmd = new MySqlCommand(query, connection);
                connection.Open();
                reader = cmd.ExecuteReader();


                while (reader.Read())
                {


                    name1[count] = reader.GetString(col1);
                    name2[count] = reader.GetString(col2);
                    name3[count] = reader.GetString(col3);
                    name4[count] = reader.GetString(col4);
                    name5[count] = reader.GetString(col5);
                    name6[count] = reader.GetString(col6);
                    name7[count] = reader.GetString(col7);
                    name8[count] = reader.GetString(col8);
                    count++;

                }

                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }







        //----------------------------------------------------------------------------

        // function for textbox textchange START
        public void TbxSelectedTextChange(string query, string column, TextBox tbx)
        {
            try
            {
                dbs_connection();
                cmd = new MySqlCommand(query, connection);
                connection.Open();
                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    string item = reader.GetString(column);
                    tbx.Text = item;
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // function for textbox textchange END

        //----------------------------------------------------------------------------

        // function for label textchange START
        public void LabelSelectedTChange(string query, string column, Label label)
        {
            try
            {
                dbs_connection();
                cmd = new MySqlCommand(query, connection);
                connection.Open();
                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    string item = reader.GetString(column);

                    label.Text = item;
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // function for label textchange END



        public string GetStringFromDbs(string query, string column)
        {
            try
            {
                dbs_connection();
                cmd = new MySqlCommand(query, connection);
                connection.Open();
                reader = cmd.ExecuteReader();

                string item = "null";
                while (reader.Read())
                {
                    item = reader.GetString(column);

                }

                reader.Close();
                connection.Close();
                return item;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }



        //------------------------------------------------------------------------------


        public string GetStringFromDbs(string query, string column, string[] array, ref int size)
        {
            try
            {

                dbs_connection();
                cmd = new MySqlCommand(query, connection);
                connection.Open();
                reader = cmd.ExecuteReader();

                string item = "null";
                while (reader.Read())
                {
                    array[size] = reader.GetString(column);
                    size++;
                }

                reader.Close();
                connection.Close();
                return item;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }



        // function for add checkbox to datagridview START

        public void addchekbox(DataGridView dgv)
        {
            DataGridViewCheckBoxColumn col = new DataGridViewCheckBoxColumn()
            {
                Name = "#",
                Width = 35
            };
            dgv.Columns.Add(col);
        }

        // function for add checkbox to datagridview END
        //----------------------------



        //function Autocomplete textboxex.................
        public void AutocompleteTexbox(string query, TextBox tbx, string column)
        {
            tbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbx.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection value = new AutoCompleteStringCollection();
            dbs_connection();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader myreader;

            try
            {
                connection.Open();
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {
                    string customer_name = myreader.GetString(column);
                    value.Add(customer_name);
                }

                connection.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            tbx.AutoCompleteCustomSource = value;


        }

        //function Autocomplete textboxex.................



        public void AutocompleteComboBox(string query, ComboBox cbx, string column)
        {
            cbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbx.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection value = new AutoCompleteStringCollection();
            dbs_connection();
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader myreader;

            try
            {
                connection.Open();
                myreader = command.ExecuteReader();
                while (myreader.Read())
                {
                    string customer_name = myreader.GetString(column);
                    value.Add(customer_name);
                }

                connection.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            cbx.AutoCompleteCustomSource = value;


        }



        //checkvalue in database...............

        public void ValueChecker(string query_check, string query_insert, string query_update)
        {
            dbs_connection();
            MySqlCommand command = new MySqlCommand(query_check, connection);
            MySqlDataReader myreader;

            try
            {
                connection.Open();
                myreader = command.ExecuteReader();

                if (myreader.Read())
                {
                    myreader.Close();
                    MySqlCommand command_update = new MySqlCommand(query_update, connection);
                    MySqlDataReader reader_update = command_update.ExecuteReader();
                    reader_update.Close();
                }

                else
                {
                    myreader.Close();
                    MySqlCommand command_insert = new MySqlCommand(query_insert, connection);
                    MySqlDataReader reader_insert;

                    reader_insert = command_insert.ExecuteReader();
                    reader_insert.Close();
                }


                connection.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }



        //checkvalue in database...............

        public void ValueChecker(string query_check, string query_get_prereqs, DataGridView dgv)
        {
            int size = 0;
            dbs_connection();
            MySqlCommand command = new MySqlCommand(query_check, connection);
            MySqlDataReader myreader;
            addchekbox(dgv);
            try
            {
                connection.Open();
                myreader = command.ExecuteReader();

                if (myreader.Read())
                {
                    myreader.Close();
                    string[] course_prereq = new string[50];

                    GetStringFromDbs(query_get_prereqs, "course_prereq", course_prereq, ref size);


                    dgv.Columns.Add("c2", "Course Id");
                    dgv.Columns.Add("c3", "course Name");

                    for (int i = 0; i < size; i++)
                    {
                        dgv.Rows.Add(false, course_prereq[i], GetStringFromDbs("select course_prereq_name from iub.prereq where course_prereq='" + course_prereq[i] + "'", "course_prereq_name"));
                    }

                    //DgvDisplay(query_display, dgv);
                }

                else
                {

                    dgv.Columns.Add("c2", "Course Id");
                    dgv.Columns.Add("c3", "course Name");

                }

                connection.Close();
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        //autocomplete searchbox


        public void AutocompleteSearchBox(TextBox tbx, DataGridView dgv)
        {
            tbx.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            tbx.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection value = new AutoCompleteStringCollection();




            int count = dgv.ColumnCount;
            int rowIndex = 0;

            foreach (DataGridViewRow row in dgv.Rows)
            {

                for (int index = 1; index < count; index++)
                {

                    value.Add(row.Cells[index].Value.ToString());


                }
                rowIndex++;

            }



            tbx.AutoCompleteCustomSource = value;

        }


        //autocomplete searchbox



        //translator_EtoB


        public string translator_EtoB(string eng)
        {

            string bangla0 = eng.Replace("0", "০");
            string bangla1 = bangla0.Replace("1", "১");
            string bangla2 = bangla1.Replace("2", "২");
            string bangla3 = bangla2.Replace("3", "৩");
            string bangla4 = bangla3.Replace("4", "৪");
            string bangla5 = bangla4.Replace("5", "৫");
            string bangla6 = bangla5.Replace("6", "৬");
            string bangla7 = bangla6.Replace("7", "৭");
            string bangla8 = bangla7.Replace("8", "৮");
            string bangla9 = bangla8.Replace("9", "৯");

            return bangla9;

        }


        //translator_EtoB



        //translator_BtoE
        public string translator_BtoE(string eng)
        {

            string bangla0 = eng.Replace("০", "0");
            string bangla1 = bangla0.Replace("১", "1");
            string bangla2 = bangla1.Replace("২", "2");
            string bangla3 = bangla2.Replace("৩", "3");
            string bangla4 = bangla3.Replace("৪", "4");
            string bangla5 = bangla4.Replace("৫", "5");
            string bangla6 = bangla5.Replace("৬", "6");
            string bangla7 = bangla6.Replace("৭", "7");
            string bangla8 = bangla7.Replace("৮", "8");
            string bangla9 = bangla8.Replace("৯", "9");

            return bangla9;

        }



        //translator_BtoE

        // function for label textchange START
        public void LabelSelectedTextChangeBangla(string query, string column, Label label)
        {
            try
            {
                dbs_connection();
                cmd = new MySqlCommand(query, connection);
                connection.Open();
                reader = cmd.ExecuteReader();


                while (reader.Read())
                {
                    string item = reader.GetString(column);

                    label.Text = translator_EtoB(item);
                }
                reader.Close();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        // function for label textchange END


        // function for chartview



        public void ChartView(Chart chart, string series_name, string x, string y, string query)
        {

            chart.Series[series_name].Points.Clear();
            chart.Visible = true;
            string temp_major, major;

            try
            {
                dbs_connection();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    temp_major = reader.GetString(x);
                    if (temp_major == "Computer Science")
                    { major = "CS"; }

                    else if (temp_major == "Computer Engineering")
                    { major = "CE"; }

                    else if (temp_major == "Computer Information System")
                    { major = "CIS"; }

                    else if (temp_major == "Electrical and Electronic Engineering")
                    { major = "EEE"; }

                    else if (temp_major == "Electronic and Telecommunication Engineering")
                    { major = "ETE"; }

                    else if (temp_major == string.Empty)
                    {
                        major = "!";
                    }
                    else major = temp_major;

                    chart.Series[series_name].Points.AddXY(major, Math.Round(reader.GetDouble(y), 2));

                }

                reader.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }


        }




        //function for chartview


        public void chart_pie_custom(Chart chart, string series, string[] grade, Double[] num)
        {

            chart.Series[series].Points.DataBindXY(grade, num);

        }









        public void ChartView_Series_4(Chart chart, string s1, string x1, string s2, string x2, string s3, string x3, string s4, string x4, string y, string query)
        {

            chart.Series[s1].Points.Clear();
            chart.Series[s2].Points.Clear();
            chart.Series[s3].Points.Clear();
            chart.Series[s4].Points.Clear();
            chart.Visible = true;


            try
            {
                dbs_connection();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    chart.Series[s1].Points.AddXY(reader.GetString(y), reader.GetInt64(x1));
                    chart.Series[s2].Points.AddXY(reader.GetString(y), reader.GetInt64(x2));
                    chart.Series[s3].Points.AddXY(reader.GetString(y), reader.GetInt64(x3));
                    chart.Series[s4].Points.AddXY(reader.GetString(y), reader.GetInt64(x4));


                }

                reader.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }


        }



        public void ChartView_Series_4(Chart chart, string s1, string s2, string s3, string s4, string x, string y, string query)
        {

            chart.Series[s1].Points.Clear();
            chart.Series[s2].Points.Clear();
            chart.Series[s3].Points.Clear();
            chart.Series[s4].Points.Clear();
            chart.Visible = true;

            string cs = "Computer Science", ce = "Computer Engineering", eee = "Electrical and Electronic Engineering", ete = "Electrical and Electronic Engineering";

            try
            {
                dbs_connection();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {

                    if (x == "Computer Science")

                        chart.Series[s1].Points.AddXY(reader.GetString(y), reader.GetInt64(cs));

                    if (x == "Computer Engineering")

                        chart.Series[s2].Points.AddXY(reader.GetString(y), reader.GetInt64(ce));

                    if (x == "Electrical and Electronic Engineering")

                        chart.Series[s3].Points.AddXY(reader.GetString(y), reader.GetInt64(eee));


                    if (x == "Electrical and Electronic Engineering")
                        chart.Series[s4].Points.AddXY(reader.GetString(y), reader.GetInt64(ete));


                }

                reader.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }


        }



        public void ChartView_Series_2(Chart chart, string s1, string x1, string s2, string x2, string y, string query)
        {

            chart.Series[s1].Points.Clear();
            chart.Series[s2].Points.Clear();
            chart.Visible = true;
            double x2_temp;
            double x1_temp;



            try
            {
                dbs_connection();
                MySqlCommand command = new MySqlCommand(query, connection);
                MySqlDataReader reader;
                connection.Open();
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string major = reader.GetString(y);
                    if (major == "Computer Science")
                        major = "CS";

                    else if (major == "Computer Engineering")
                        major = "CE";


                    else if (major == "Electrical and Electronic Engineering")
                        major = "EEE";



                    else if (major == "Electronic and Telecommunication Engineering")
                        major = "ETE";



                    else if (major == "Computer Information System")
                        major = "CIS";

                    else if (major == "")
                        major = "!";

                    else
                        major = reader.GetString(y);

                    x2_temp = Math.Round(reader.GetDouble(x2), 2);
                    x1_temp = Math.Round(reader.GetDouble(x1), 2);
                    chart.Series[s1].Points.AddXY(major, x1_temp);
                    chart.Series[s2].Points.AddXY(major, x2_temp);


                }

                reader.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }


        }



        //backup


      /*  public void Backupdb()
        {
            OpenFileDialog opfd = new OpenFileDialog();
            opfd.Filter = "SQL files|*.sql";
            if (opfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filename = opfd.FileName;
                string constring = "server=localhost;user=root;pwd=root;database=iub;";
                MySqlConnection con = new MySqlConnection(constring);
                MySqlCommand cmd = new MySqlCommand();
                MySqlBackup back = new MySqlBackup(cmd);
                cmd.Connection = con;
                con.Open();
                back.ImportFromFile(filename);
                con.Close();

                MessageBox.Show("Data Import Completed !");
            }
        }


        //*/


    }
}
