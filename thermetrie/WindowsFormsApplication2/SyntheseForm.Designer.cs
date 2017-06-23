namespace WindowsFormsApplication2
{
    partial class SyntheseForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea13 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend13 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea14 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend14 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea15 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend15 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graphHumid = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.graphTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tempMax = new System.Windows.Forms.Label();
            this.tempMoy = new System.Windows.Forms.Label();
            this.tempMin = new System.Windows.Forms.Label();
            this.tempMaxLabel = new MaterialSkin.Controls.MaterialLabel();
            this.tempMoyLabel = new MaterialSkin.Controls.MaterialLabel();
            this.tempMinLabel = new MaterialSkin.Controls.MaterialLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.term = new MaterialSkin.Controls.MaterialLabel();
            this.endDate = new MaterialSkin.Controls.MaterialLabel();
            this.startDate = new MaterialSkin.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.nameSensorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.uidSensorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            chartArea13.Area3DStyle.Enable3D = true;
            chartArea13.Name = "ChartArea1";
            this.graphHumid.ChartAreas.Add(chartArea13);
            this.graphHumid.Dock = System.Windows.Forms.DockStyle.Fill;
            legend13.Enabled = false;
            legend13.Name = "Legend1";
            this.graphHumid.Legends.Add(legend13);
            this.graphHumid.Location = new System.Drawing.Point(0, 0);
            this.graphHumid.Name = "graphHumid";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series13.IsVisibleInLegend = false;
            series13.Legend = "Legend1";
            series13.Name = "Series1";
            this.graphHumid.Series.Add(series13);
            this.graphHumid.Size = new System.Drawing.Size(294, 204);
            this.graphHumid.TabIndex = 0;
            this.graphHumid.Text = "chart1";
            // 
            // graphTemp
            // 
            this.graphTemp.BackColor = System.Drawing.Color.Transparent;
            chartArea14.Area3DStyle.Enable3D = true;
            chartArea14.Name = "ChartArea1";
            this.graphTemp.ChartAreas.Add(chartArea14);
            this.graphTemp.Dock = System.Windows.Forms.DockStyle.Fill;
            legend14.Enabled = false;
            legend14.Name = "Legend1";
            this.graphTemp.Legends.Add(legend14);
            this.graphTemp.Location = new System.Drawing.Point(0, 0);
            this.graphTemp.Name = "graphTemp";
            series14.ChartArea = "ChartArea1";
            series14.IsVisibleInLegend = false;
            series14.Legend = "Legend1";
            series14.Name = "Series1";
            this.graphTemp.Series.Add(series14);
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
            // tempMaxLabel
            // 
            this.tempMaxLabel.AutoSize = true;
            this.tempMaxLabel.Depth = 0;
            this.tempMaxLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.tempMaxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tempMaxLabel.Location = new System.Drawing.Point(185, 15);
            this.tempMaxLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.tempMaxLabel.Name = "tempMaxLabel";
            this.tempMaxLabel.Size = new System.Drawing.Size(79, 19);
            this.tempMaxLabel.TabIndex = 2;
            this.tempMaxLabel.Text = "Temp Max";
            // 
            // tempMoyLabel
            // 
            this.tempMoyLabel.AutoSize = true;
            this.tempMoyLabel.Depth = 0;
            this.tempMoyLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.tempMoyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tempMoyLabel.Location = new System.Drawing.Point(98, 15);
            this.tempMoyLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.tempMoyLabel.Name = "tempMoyLabel";
            this.tempMoyLabel.Size = new System.Drawing.Size(80, 19);
            this.tempMoyLabel.TabIndex = 1;
            this.tempMoyLabel.Text = "Temp Moy";
            // 
            // tempMinLabel
            // 
            this.tempMinLabel.AutoSize = true;
            this.tempMinLabel.Depth = 0;
            this.tempMinLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.tempMinLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tempMinLabel.Location = new System.Drawing.Point(16, 15);
            this.tempMinLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.tempMinLabel.Name = "tempMinLabel";
            this.tempMinLabel.Size = new System.Drawing.Size(76, 19);
            this.tempMinLabel.TabIndex = 0;
            this.tempMinLabel.Text = "Temp Min";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.term);
            this.panel2.Controls.Add(this.endDate);
            this.panel2.Controls.Add(this.startDate);
            this.panel2.Location = new System.Drawing.Point(391, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 105);
            this.panel2.TabIndex = 3;
            // 
            // term
            // 
            this.term.Depth = 0;
            this.term.Font = new System.Drawing.Font("Roboto", 11F);
            this.term.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.term.Location = new System.Drawing.Point(106, 76);
            this.term.MouseState = MaterialSkin.MouseState.HOVER;
            this.term.Name = "term";
            this.term.Size = new System.Drawing.Size(110, 19);
            this.term.TabIndex = 21;
            // 
            // endDate
            // 
            this.endDate.Depth = 0;
            this.endDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.endDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.endDate.Location = new System.Drawing.Point(106, 41);
            this.endDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(115, 19);
            this.endDate.TabIndex = 20;
            this.endDate.Text = "Date de fin";
            // 
            // startDate
            // 
            this.startDate.Depth = 0;
            this.startDate.Font = new System.Drawing.Font("Roboto", 11F);
            this.startDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.startDate.Location = new System.Drawing.Point(106, 8);
            this.startDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(119, 19);
            this.startDate.TabIndex = 19;
            this.startDate.Text = "Date de debut";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.nameSensorLabel);
            this.panel3.Controls.Add(this.uidSensorLabel);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 105);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Uid du capteur :";
            // 
            // nameSensorLabel
            // 
            this.nameSensorLabel.Depth = 0;
            this.nameSensorLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.nameSensorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.nameSensorLabel.Location = new System.Drawing.Point(148, 40);
            this.nameSensorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.nameSensorLabel.Name = "nameSensorLabel";
            this.nameSensorLabel.Size = new System.Drawing.Size(225, 19);
            this.nameSensorLabel.TabIndex = 19;
            // 
            // uidSensorLabel
            // 
            this.uidSensorLabel.Depth = 0;
            this.uidSensorLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.uidSensorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.uidSensorLabel.Location = new System.Drawing.Point(144, 8);
            this.uidSensorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.uidSensorLabel.Name = "uidSensorLabel";
            this.uidSensorLabel.Size = new System.Drawing.Size(229, 19);
            this.uidSensorLabel.TabIndex = 18;
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
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea15.Area3DStyle.Enable3D = true;
            chartArea15.Area3DStyle.Inclination = 15;
            chartArea15.BackColor = System.Drawing.Color.Transparent;
            chartArea15.BackSecondaryColor = System.Drawing.Color.Transparent;
            chartArea15.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea15);
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend15.Enabled = false;
            legend15.Name = "Legend1";
            this.chart1.Legends.Add(legend15);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series15.CustomProperties = "DoughnutRadius=30";
            series15.IsVisibleInLegend = false;
            series15.Legend = "Legend1";
            series15.Name = "Series1";
            this.chart1.Series.Add(series15);
            this.chart1.Size = new System.Drawing.Size(294, 85);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 21;
            this.label2.Text = "Nom du capteur :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Periode du :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Aux :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Durée :";
            // 
            // SyntheseForm
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
            this.Name = "SyntheseForm";
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MaterialSkin.Controls.MaterialLabel term;
        private MaterialSkin.Controls.MaterialLabel endDate;
        private MaterialSkin.Controls.MaterialLabel startDate;
        private MaterialSkin.Controls.MaterialLabel nameSensorLabel;
        private MaterialSkin.Controls.MaterialLabel uidSensorLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}