namespace nasa
{
    partial class Dashbord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.dgv_dataset = new System.Windows.Forms.DataGridView();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.chart_pie_actual_data = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.webBrowser2 = new System.Windows.Forms.WebBrowser();
            this.webBrowser3 = new System.Windows.Forms.WebBrowser();
            this.chart_pie_standard = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btn_reset = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataset)).BeginInit();
            this.metroTabPage3.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_pie_actual_data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_pie_standard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Controls.Add(this.metroTabPage4);
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.metroTabControl1.Location = new System.Drawing.Point(22, 63);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(1174, 492);
            this.metroTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.dgv_dataset);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1166, 400);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Data Set          ";
            this.metroTabPage1.UseStyleColors = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.webBrowser1);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1166, 450);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Map         ";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // dgv_dataset
            // 
            this.dgv_dataset.AllowUserToAddRows = false;
            this.dgv_dataset.AllowUserToDeleteRows = false;
            this.dgv_dataset.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.dgv_dataset.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_dataset.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_dataset.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_dataset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_dataset.ColumnHeadersHeight = 30;
            this.dgv_dataset.Location = new System.Drawing.Point(0, 42);
            this.dgv_dataset.Name = "dgv_dataset";
            this.dgv_dataset.ReadOnly = true;
            this.dgv_dataset.RowHeadersVisible = false;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dgv_dataset.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_dataset.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_dataset.Size = new System.Drawing.Size(1170, 442);
            this.dgv_dataset.TabIndex = 82;
            this.dgv_dataset.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dataset_CellContentDoubleClick);
            this.dgv_dataset.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dataset_CellDoubleClick);
            this.dgv_dataset.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_dataset_CellMouseDoubleClick);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 22);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1170, 413);
            this.webBrowser1.TabIndex = 2;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroLabel1);
            this.metroTabPage3.Controls.Add(this.metroLabel13);
            this.metroTabPage3.Controls.Add(this.chart_pie_standard);
            this.metroTabPage3.Controls.Add(this.webBrowser3);
            this.metroTabPage3.Controls.Add(this.chart_pie_actual_data);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(1166, 450);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Vizualization          ";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.webBrowser2);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(1166, 450);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "All Locations             ";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // chart_pie_actual_data
            // 
            this.chart_pie_actual_data.BackSecondaryColor = System.Drawing.Color.Lime;
            chartArea14.Area3DStyle.Inclination = 45;
            chartArea14.Area3DStyle.IsClustered = true;
            chartArea14.Area3DStyle.IsRightAngleAxes = false;
            chartArea14.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea14.Area3DStyle.Rotation = 45;
            chartArea14.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea14.AxisX.Interval = 1D;
            chartArea14.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea14.AxisX.IsLabelAutoFit = false;
            chartArea14.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea14.AxisX.MajorGrid.Enabled = false;
            chartArea14.AxisX.Minimum = 0D;
            chartArea14.AxisX.ScaleView.Position = 0D;
            chartArea14.AxisX.ScaleView.Size = 8D;
            chartArea14.AxisX.ScaleView.Zoomable = false;
            chartArea14.AxisX.ScrollBar.BackColor = System.Drawing.Color.Gainsboro;
            chartArea14.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea14.AxisX.ScrollBar.IsPositionedInside = false;
            chartArea14.BackColor = System.Drawing.Color.White;
            chartArea14.Name = "ChartArea1";
            this.chart_pie_actual_data.ChartAreas.Add(chartArea14);
            legend14.Name = "Legend1";
            this.chart_pie_actual_data.Legends.Add(legend14);
            this.chart_pie_actual_data.Location = new System.Drawing.Point(670, 74);
            this.chart_pie_actual_data.Name = "chart_pie_actual_data";
            this.chart_pie_actual_data.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.chart_pie_actual_data.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))))};
            series14.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series14.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            series14.BackImageTransparentColor = System.Drawing.Color.Black;
            series14.BackSecondaryColor = System.Drawing.Color.MintCream;
            series14.BorderColor = System.Drawing.Color.Black;
            series14.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series14.BorderWidth = 5;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series14.Color = System.Drawing.Color.DarkSlateGray;
            series14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series14.IsValueShownAsLabel = true;
            series14.IsXValueIndexed = true;
            series14.Label = "#PERCENT{P0}";
            series14.Legend = "Legend1";
            series14.LegendText = "#VALX";
            series14.Name = "ChartView";
            series14.ShadowColor = System.Drawing.Color.DarkGray;
            series14.ShadowOffset = 8;
            this.chart_pie_actual_data.Series.Add(series14);
            this.chart_pie_actual_data.Size = new System.Drawing.Size(471, 342);
            this.chart_pie_actual_data.TabIndex = 83;
            this.chart_pie_actual_data.Text = "chart1";
            this.chart_pie_actual_data.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            this.chart_pie_actual_data.Visible = false;
            // 
            // webBrowser2
            // 
            this.webBrowser2.Location = new System.Drawing.Point(7, 12);
            this.webBrowser2.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser2.Name = "webBrowser2";
            this.webBrowser2.Size = new System.Drawing.Size(1163, 438);
            this.webBrowser2.TabIndex = 3;
            // 
            // webBrowser3
            // 
            this.webBrowser3.Location = new System.Drawing.Point(500, 39);
            this.webBrowser3.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser3.Name = "webBrowser3";
            this.webBrowser3.Size = new System.Drawing.Size(93, 37);
            this.webBrowser3.TabIndex = 84;
            this.webBrowser3.Visible = false;
            // 
            // chart_pie_standard
            // 
            this.chart_pie_standard.BackSecondaryColor = System.Drawing.Color.Lime;
            chartArea13.Area3DStyle.Inclination = 45;
            chartArea13.Area3DStyle.IsClustered = true;
            chartArea13.Area3DStyle.IsRightAngleAxes = false;
            chartArea13.Area3DStyle.LightStyle = System.Windows.Forms.DataVisualization.Charting.LightStyle.Realistic;
            chartArea13.Area3DStyle.Rotation = 45;
            chartArea13.AxisX.Crossing = -1.7976931348623157E+308D;
            chartArea13.AxisX.Interval = 1D;
            chartArea13.AxisX.IntervalAutoMode = System.Windows.Forms.DataVisualization.Charting.IntervalAutoMode.VariableCount;
            chartArea13.AxisX.IsLabelAutoFit = false;
            chartArea13.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            chartArea13.AxisX.MajorGrid.Enabled = false;
            chartArea13.AxisX.Minimum = 0D;
            chartArea13.AxisX.ScaleView.Position = 0D;
            chartArea13.AxisX.ScaleView.Size = 8D;
            chartArea13.AxisX.ScaleView.Zoomable = false;
            chartArea13.AxisX.ScrollBar.BackColor = System.Drawing.Color.Gainsboro;
            chartArea13.AxisX.ScrollBar.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            chartArea13.AxisX.ScrollBar.IsPositionedInside = false;
            chartArea13.BackColor = System.Drawing.Color.White;
            chartArea13.Name = "ChartArea1";
            this.chart_pie_standard.ChartAreas.Add(chartArea13);
            legend13.Name = "Legend1";
            this.chart_pie_standard.Legends.Add(legend13);
            this.chart_pie_standard.Location = new System.Drawing.Point(0, 74);
            this.chart_pie_standard.Name = "chart_pie_standard";
            this.chart_pie_standard.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            this.chart_pie_standard.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))))};
            series13.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.DiagonalLeft;
            series13.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Top;
            series13.BackImageTransparentColor = System.Drawing.Color.Black;
            series13.BackSecondaryColor = System.Drawing.Color.MintCream;
            series13.BorderColor = System.Drawing.Color.Black;
            series13.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.NotSet;
            series13.BorderWidth = 5;
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series13.Color = System.Drawing.Color.DarkSlateGray;
            series13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series13.IsValueShownAsLabel = true;
            series13.IsXValueIndexed = true;
            series13.Label = "#PERCENT{P0}";
            series13.Legend = "Legend1";
            series13.LegendText = "#VALX";
            series13.Name = "ChartView";
            series13.ShadowColor = System.Drawing.Color.DarkGray;
            series13.ShadowOffset = 8;
            this.chart_pie_standard.Series.Add(series13);
            this.chart_pie_standard.Size = new System.Drawing.Size(471, 342);
            this.chart_pie_standard.TabIndex = 85;
            this.chart_pie_standard.Text = "chart1";
            this.chart_pie_standard.TextAntiAliasingQuality = System.Windows.Forms.DataVisualization.Charting.TextAntiAliasingQuality.SystemDefault;
            this.chart_pie_standard.Visible = false;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel13.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel13.Location = new System.Drawing.Point(122, 39);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(145, 25);
            this.metroLabel13.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel13.TabIndex = 103;
            this.metroLabel13.Text = "Standard Water";
            this.metroLabel13.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(796, 39);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(123, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel1.TabIndex = 104;
            this.metroLabel1.Text = "Actual Water";
            this.metroLabel1.UseStyleColors = true;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.Transparent;
            this.btn_reset.BackgroundImage = global::nasa.Properties.Resources.refresh2;
            this.btn_reset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btn_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Location = new System.Drawing.Point(715, 25);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(57, 55);
            this.btn_reset.TabIndex = 114;
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::nasa.Properties.Resources.line;
            this.pictureBox1.Location = new System.Drawing.Point(72, 586);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1095, 3);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(887, 37);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(259, 25);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel2.TabIndex = 105;
            this.metroLabel2.Text = "Global Water Maper  |  NASA";
            this.metroLabel2.UseStyleColors = true;
            // 
            // Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1219, 615);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "Dashbord";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.DropShadow;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Load += new System.EventHandler(this.Dashbord_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dataset)).EndInit();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.metroTabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_pie_actual_data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_pie_standard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.DataGridView dgv_dataset;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_pie_actual_data;
        private System.Windows.Forms.WebBrowser webBrowser2;
        private System.Windows.Forms.WebBrowser webBrowser3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_pie_standard;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_reset;
        private MetroFramework.Controls.MetroLabel metroLabel2;


    }
}

