namespace SensorBoard
{
    partial class SyntForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graphHumid = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graphTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tempMinLabel = new MaterialSkin.Controls.MaterialLabel();
            this.tempMoyLabel = new MaterialSkin.Controls.MaterialLabel();
            this.tempMaxLabel = new MaterialSkin.Controls.MaterialLabel();
            this.tempMin = new System.Windows.Forms.Label();
            this.tempMoy = new System.Windows.Forms.Label();
            this.tempMax = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.periodeDebutCB = new System.Windows.Forms.ComboBox();
            this.periodeFinCB = new System.Windows.Forms.ComboBox();
            this.dureeCB = new System.Windows.Forms.ComboBox();
            this.nameCaptCB = new System.Windows.Forms.ComboBox();
            this.idCapteur = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.graphHumid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphTemp)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // graphHumid
            // 
            this.graphHumid.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea1";
            this.graphHumid.ChartAreas.Add(chartArea1);
            this.graphHumid.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.graphHumid.Legends.Add(legend1);
            this.graphHumid.Location = new System.Drawing.Point(0, 0);
            this.graphHumid.Name = "graphHumid";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graphHumid.Series.Add(series1);
            this.graphHumid.Size = new System.Drawing.Size(294, 204);
            this.graphHumid.TabIndex = 0;
            this.graphHumid.Text = "chart1";
            // 
            // graphTemp
            // 
            this.graphTemp.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Name = "ChartArea1";
            this.graphTemp.ChartAreas.Add(chartArea2);
            this.graphTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.graphTemp.Legends.Add(legend2);
            this.graphTemp.Location = new System.Drawing.Point(0, 0);
            this.graphTemp.Name = "graphTemp";
            series2.ChartArea = "ChartArea1";
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.graphTemp.Series.Add(series2);
            this.graphTemp.Size = new System.Drawing.Size(288, 204);
            this.graphTemp.TabIndex = 1;
            this.graphTemp.Text = "chart2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tempMax);
            this.panel1.Controls.Add(this.tempMoy);
            this.panel1.Controls.Add(this.tempMin);
            this.panel1.Controls.Add(this.tempMaxLabel);
            this.panel1.Controls.Add(this.tempMoyLabel);
            this.panel1.Controls.Add(this.tempMinLabel);
            this.panel1.Location = new System.Drawing.Point(328, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 85);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dureeCB);
            this.panel2.Controls.Add(this.periodeFinCB);
            this.panel2.Controls.Add(this.periodeDebutCB);
            this.panel2.Controls.Add(this.materialLabel8);
            this.panel2.Controls.Add(this.materialLabel7);
            this.panel2.Controls.Add(this.materialLabel6);
            this.panel2.Location = new System.Drawing.Point(391, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 105);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.idCapteur);
            this.panel3.Controls.Add(this.nameCaptCB);
            this.panel3.Controls.Add(this.materialLabel5);
            this.panel3.Controls.Add(this.materialLabel4);
            this.panel3.Controls.Add(this.materialLabel3);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 105);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.graphTemp);
            this.panel4.Location = new System.Drawing.Point(328, 250);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(288, 204);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.graphHumid);
            this.panel5.Location = new System.Drawing.Point(12, 250);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(294, 204);
            this.panel5.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.chart1);
            this.panel6.Location = new System.Drawing.Point(12, 125);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(294, 85);
            this.panel6.TabIndex = 4;
            // 
            // tempMinLabel
            // 
            this.tempMinLabel.AutoSize = true;
            this.tempMinLabel.Depth = 0;
            this.tempMinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.tempMinLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tempMinLabel.Location = new System.Drawing.Point(16, 15);
            this.tempMinLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.tempMinLabel.Name = "tempMinLabel";
            this.tempMinLabel.Size = new System.Drawing.Size(82, 18);
            this.tempMinLabel.TabIndex = 0;
            this.tempMinLabel.Text = "Temp Min";
            // 
            // tempMoyLabel
            // 
            this.tempMoyLabel.AutoSize = true;
            this.tempMoyLabel.Depth = 0;
            this.tempMoyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.tempMoyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tempMoyLabel.Location = new System.Drawing.Point(98, 15);
            this.tempMoyLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.tempMoyLabel.Name = "tempMoyLabel";
            this.tempMoyLabel.Size = new System.Drawing.Size(87, 18);
            this.tempMoyLabel.TabIndex = 1;
            this.tempMoyLabel.Text = "Temp Moy";
            // 
            // tempMaxLabel
            // 
            this.tempMaxLabel.AutoSize = true;
            this.tempMaxLabel.Depth = 0;
            this.tempMaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.tempMaxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tempMaxLabel.Location = new System.Drawing.Point(185, 15);
            this.tempMaxLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.tempMaxLabel.Name = "tempMaxLabel";
            this.tempMaxLabel.Size = new System.Drawing.Size(86, 18);
            this.tempMaxLabel.TabIndex = 2;
            this.tempMaxLabel.Text = "Temp Max";
            // 
            // tempMin
            // 
            this.tempMin.AutoSize = true;
            this.tempMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempMin.ForeColor = System.Drawing.Color.SteelBlue;
            this.tempMin.Location = new System.Drawing.Point(34, 48);
            this.tempMin.Name = "tempMin";
            this.tempMin.Size = new System.Drawing.Size(45, 25);
            this.tempMin.TabIndex = 3;
            this.tempMin.Text = "20°";
            // 
            // tempMoy
            // 
            this.tempMoy.AutoSize = true;
            this.tempMoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempMoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tempMoy.Location = new System.Drawing.Point(122, 48);
            this.tempMoy.Name = "tempMoy";
            this.tempMoy.Size = new System.Drawing.Size(45, 25);
            this.tempMoy.TabIndex = 4;
            this.tempMoy.Text = "21°";
            // 
            // tempMax
            // 
            this.tempMax.AutoSize = true;
            this.tempMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tempMax.Location = new System.Drawing.Point(206, 48);
            this.tempMax.Name = "tempMax";
            this.tempMax.Size = new System.Drawing.Size(45, 25);
            this.tempMax.TabIndex = 5;
            this.tempMax.Text = "22°";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(425, 228);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(94, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Température";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(126, 228);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(70, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Humidité";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(47, 7);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(31, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "ID :";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(9, 41);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(69, 19);
            this.materialLabel4.TabIndex = 8;
            this.materialLabel4.Text = "Capteur :";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(40, 77);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(38, 19);
            this.materialLabel5.TabIndex = 9;
            this.materialLabel5.Text = "??? :";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(3, 7);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(88, 19);
            this.materialLabel6.TabIndex = 9;
            this.materialLabel6.Text = "Periode du :";
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(58, 41);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(33, 19);
            this.materialLabel7.TabIndex = 10;
            this.materialLabel7.Text = "au :";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(35, 77);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(56, 19);
            this.materialLabel8.TabIndex = 11;
            this.materialLabel8.Text = "Durée :";
            // 
            // periodeDebutCB
            // 
            this.periodeDebutCB.FormattingEnabled = true;
            this.periodeDebutCB.Location = new System.Drawing.Point(97, 8);
            this.periodeDebutCB.Name = "periodeDebutCB";
            this.periodeDebutCB.Size = new System.Drawing.Size(121, 21);
            this.periodeDebutCB.TabIndex = 12;
            // 
            // periodeFinCB
            // 
            this.periodeFinCB.FormattingEnabled = true;
            this.periodeFinCB.Location = new System.Drawing.Point(97, 42);
            this.periodeFinCB.Name = "periodeFinCB";
            this.periodeFinCB.Size = new System.Drawing.Size(121, 21);
            this.periodeFinCB.TabIndex = 13;
            // 
            // dureeCB
            // 
            this.dureeCB.FormattingEnabled = true;
            this.dureeCB.Location = new System.Drawing.Point(97, 78);
            this.dureeCB.Name = "dureeCB";
            this.dureeCB.Size = new System.Drawing.Size(121, 21);
            this.dureeCB.TabIndex = 14;
            // 
            // nameCaptCB
            // 
            this.nameCaptCB.FormattingEnabled = true;
            this.nameCaptCB.Location = new System.Drawing.Point(84, 42);
            this.nameCaptCB.Name = "nameCaptCB";
            this.nameCaptCB.Size = new System.Drawing.Size(262, 21);
            this.nameCaptCB.TabIndex = 15;
            // 
            // idCapteur
            // 
            this.idCapteur.Depth = 0;
            this.idCapteur.Hint = "";
            this.idCapteur.Location = new System.Drawing.Point(84, 8);
            this.idCapteur.MouseState = MaterialSkin.MouseState.HOVER;
            this.idCapteur.Name = "idCapteur";
            this.idCapteur.PasswordChar = '\0';
            this.idCapteur.SelectedText = "";
            this.idCapteur.SelectionLength = 0;
            this.idCapteur.SelectionStart = 0;
            this.idCapteur.Size = new System.Drawing.Size(262, 23);
            this.idCapteur.TabIndex = 16;
            this.idCapteur.Text = "Id du capteur sélèctionné";
            this.idCapteur.UseSystemPasswordChar = false;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea3.Area3DStyle.Enable3D = true;
            chartArea3.Area3DStyle.Inclination = 15;
            chartArea3.BackColor = System.Drawing.Color.Transparent;
            chartArea3.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series3.CustomProperties = "DoughnutRadius=30";
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(294, 85);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // SyntForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 470);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SyntForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.graphHumid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graphTemp)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graphHumid;
        private System.Windows.Forms.DataVisualization.Charting.Chart graphTemp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialLabel tempMinLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private MaterialSkin.Controls.MaterialLabel tempMaxLabel;
        private MaterialSkin.Controls.MaterialLabel tempMoyLabel;
        private System.Windows.Forms.Label tempMax;
        private System.Windows.Forms.Label tempMoy;
        private System.Windows.Forms.Label tempMin;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.ComboBox dureeCB;
        private System.Windows.Forms.ComboBox periodeFinCB;
        private System.Windows.Forms.ComboBox periodeDebutCB;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField idCapteur;
        private System.Windows.Forms.ComboBox nameCaptCB;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}