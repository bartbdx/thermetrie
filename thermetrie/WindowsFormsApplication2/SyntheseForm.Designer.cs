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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.term = new MaterialSkin.Controls.MaterialLabel();
            this.endDate = new MaterialSkin.Controls.MaterialLabel();
            this.startDate = new MaterialSkin.Controls.MaterialLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameSensorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.uidSensorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.syntheseFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.humiMin = new System.Windows.Forms.Label();
            this.humiMoy = new System.Windows.Forms.Label();
            this.humiMax = new System.Windows.Forms.Label();
            this.tempMin = new System.Windows.Forms.Label();
            this.tempMoy = new System.Windows.Forms.Label();
            this.tempMax = new System.Windows.Forms.Label();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label7 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.syntheseFormBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.SuspendLayout();
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
            this.panel2.Size = new System.Drawing.Size(225, 74);
            this.panel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 18);
            this.label5.TabIndex = 24;
            this.label5.Text = "Durée :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "Aux :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Periode du :";
            // 
            // term
            // 
            this.term.Depth = 0;
            this.term.Font = new System.Drawing.Font("Roboto", 11F);
            this.term.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.term.Location = new System.Drawing.Point(106, 54);
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
            this.endDate.Location = new System.Drawing.Point(106, 30);
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
            this.startDate.Location = new System.Drawing.Point(106, 2);
            this.startDate.MouseState = MaterialSkin.MouseState.HOVER;
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(115, 19);
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
            this.panel3.Size = new System.Drawing.Size(373, 74);
            this.panel3.TabIndex = 3;
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
            // syntheseFormBindingSource
            // 
            this.syntheseFormBindingSource.DataSource = typeof(WindowsFormsApplication2.SyntheseForm);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(137, 128);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(40, 18);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Moy";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(44, 128);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(35, 18);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Min";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(288, 93);
            this.label6.TabIndex = 8;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(230, 128);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(39, 18);
            this.materialLabel1.TabIndex = 10;
            this.materialLabel1.Text = "Max";
            // 
            // humiMin
            // 
            this.humiMin.AutoSize = true;
            this.humiMin.BackColor = System.Drawing.Color.Transparent;
            this.humiMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humiMin.ForeColor = System.Drawing.Color.Red;
            this.humiMin.Location = new System.Drawing.Point(44, 149);
            this.humiMin.Name = "humiMin";
            this.humiMin.Size = new System.Drawing.Size(45, 24);
            this.humiMin.TabIndex = 11;
            this.humiMin.Text = "00%";
            // 
            // humiMoy
            // 
            this.humiMoy.AutoSize = true;
            this.humiMoy.BackColor = System.Drawing.Color.Transparent;
            this.humiMoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humiMoy.ForeColor = System.Drawing.Color.Green;
            this.humiMoy.Location = new System.Drawing.Point(136, 149);
            this.humiMoy.Name = "humiMoy";
            this.humiMoy.Size = new System.Drawing.Size(45, 24);
            this.humiMoy.TabIndex = 12;
            this.humiMoy.Text = "00%";
            // 
            // humiMax
            // 
            this.humiMax.AutoSize = true;
            this.humiMax.BackColor = System.Drawing.Color.Transparent;
            this.humiMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humiMax.ForeColor = System.Drawing.Color.Blue;
            this.humiMax.Location = new System.Drawing.Point(229, 149);
            this.humiMax.Name = "humiMax";
            this.humiMax.Size = new System.Drawing.Size(45, 24);
            this.humiMax.TabIndex = 13;
            this.humiMax.Text = "00%";
            // 
            // tempMin
            // 
            this.tempMin.AutoSize = true;
            this.tempMin.BackColor = System.Drawing.Color.Transparent;
            this.tempMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempMin.ForeColor = System.Drawing.Color.Blue;
            this.tempMin.Location = new System.Drawing.Point(361, 150);
            this.tempMin.Name = "tempMin";
            this.tempMin.Size = new System.Drawing.Size(45, 24);
            this.tempMin.TabIndex = 21;
            this.tempMin.Text = "00%";
            // 
            // tempMoy
            // 
            this.tempMoy.AutoSize = true;
            this.tempMoy.BackColor = System.Drawing.Color.Transparent;
            this.tempMoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempMoy.ForeColor = System.Drawing.Color.Green;
            this.tempMoy.Location = new System.Drawing.Point(457, 149);
            this.tempMoy.Name = "tempMoy";
            this.tempMoy.Size = new System.Drawing.Size(45, 24);
            this.tempMoy.TabIndex = 20;
            this.tempMoy.Text = "00%";
            // 
            // tempMax
            // 
            this.tempMax.AutoSize = true;
            this.tempMax.BackColor = System.Drawing.Color.Transparent;
            this.tempMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempMax.ForeColor = System.Drawing.Color.Red;
            this.tempMax.Location = new System.Drawing.Point(547, 149);
            this.tempMax.Name = "tempMax";
            this.tempMax.Size = new System.Drawing.Size(45, 24);
            this.tempMax.TabIndex = 19;
            this.tempMax.Text = "00%";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(548, 128);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(39, 18);
            this.materialLabel4.TabIndex = 18;
            this.materialLabel4.Text = "Max";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Black;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(330, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(288, 30);
            this.label11.TabIndex = 17;
            this.label11.Text = "Température";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(362, 128);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(35, 18);
            this.materialLabel5.TabIndex = 14;
            this.materialLabel5.Text = "Min";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(455, 128);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(40, 18);
            this.materialLabel6.TabIndex = 15;
            this.materialLabel6.Text = "Moy";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(330, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(288, 93);
            this.label12.TabIndex = 16;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.graph);
            this.panel4.Location = new System.Drawing.Point(1, 184);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(617, 286);
            this.panel4.TabIndex = 3;
            // 
            // graph
            // 
            this.graph.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Area3DStyle.Enable3D = true;
            chartArea1.Name = "ChartArea";
            this.graph.ChartAreas.Add(chartArea1);
            this.graph.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend1.MaximumAutoSize = 10F;
            legend1.Name = "humLegend";
            this.graph.Legends.Add(legend1);
            this.graph.Location = new System.Drawing.Point(0, 0);
            this.graph.Name = "graph";
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineRange;
            series1.Legend = "humLegend";
            series1.Name = "TempSeries";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValuesPerPoint = 2;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.ChartArea = "ChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "humLegend";
            series2.Name = "HumidSeries";
            series2.YValuesPerPoint = 2;
            this.graph.Series.Add(series1);
            this.graph.Series.Add(series2);
            this.graph.Size = new System.Drawing.Size(617, 286);
            this.graph.TabIndex = 0;
            this.graph.Text = "chart1";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(12, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(288, 30);
            this.label7.TabIndex = 9;
            this.label7.Text = "Humiditée";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SyntheseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 470);
            this.Controls.Add(this.tempMin);
            this.Controls.Add(this.tempMoy);
            this.Controls.Add(this.tempMax);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.humiMax);
            this.Controls.Add(this.humiMoy);
            this.Controls.Add(this.humiMin);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SyntheseForm";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.syntheseFormBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
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
        private System.Windows.Forms.BindingSource syntheseFormBindingSource;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.Label label6;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label humiMin;
        private System.Windows.Forms.Label humiMoy;
        private System.Windows.Forms.Label humiMax;
        private System.Windows.Forms.Label tempMin;
        private System.Windows.Forms.Label tempMoy;
        private System.Windows.Forms.Label tempMax;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.Label label11;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.Label label7;
    }
}