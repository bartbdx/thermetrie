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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.graph = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tempMax = new System.Windows.Forms.Label();
            this.tempMoy = new System.Windows.Forms.Label();
            this.tempMin = new System.Windows.Forms.Label();
            this.tempMaxLabel = new MaterialSkin.Controls.MaterialLabel();
            this.tempMoyLabel = new MaterialSkin.Controls.MaterialLabel();
            this.tempMinLabel = new MaterialSkin.Controls.MaterialLabel();
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
            this.panel5 = new System.Windows.Forms.Panel();
            this.syntheseFormBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.humiMax = new System.Windows.Forms.Label();
            this.humiMoy = new System.Windows.Forms.Label();
            this.humiMin = new System.Windows.Forms.Label();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.graph)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.syntheseFormBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // graph
            // 
            this.graph.BackColor = System.Drawing.Color.Transparent;
            chartArea2.Area3DStyle.Enable3D = true;
            chartArea2.Name = "ChartArea";
            this.graph.ChartAreas.Add(chartArea2);
            this.graph.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Alignment = System.Drawing.StringAlignment.Center;
            legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend2.MaximumAutoSize = 10F;
            legend2.Name = "humLegend";
            this.graph.Legends.Add(legend2);
            this.graph.Location = new System.Drawing.Point(0, 0);
            this.graph.Name = "graph";
            series3.ChartArea = "ChartArea";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineRange;
            series3.Legend = "humLegend";
            series3.Name = "TempSeries";
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series3.YValuesPerPoint = 2;
            series3.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series4.ChartArea = "ChartArea";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "humLegend";
            series4.Name = "HumidSeries";
            series4.YValuesPerPoint = 2;
            this.graph.Series.Add(series3);
            this.graph.Series.Add(series4);
            this.graph.Size = new System.Drawing.Size(617, 286);
            this.graph.TabIndex = 0;
            this.graph.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tempMax);
            this.panel1.Controls.Add(this.tempMoy);
            this.panel1.Controls.Add(this.tempMin);
            this.panel1.Controls.Add(this.tempMaxLabel);
            this.panel1.Controls.Add(this.tempMoyLabel);
            this.panel1.Controls.Add(this.tempMinLabel);
            this.panel1.Location = new System.Drawing.Point(327, 117);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(288, 45);
            this.panel1.TabIndex = 2;
            // 
            // tempMax
            // 
            this.tempMax.AutoSize = true;
            this.tempMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempMax.ForeColor = System.Drawing.Color.Red;
            this.tempMax.Location = new System.Drawing.Point(200, 20);
            this.tempMax.Name = "tempMax";
            this.tempMax.Size = new System.Drawing.Size(51, 25);
            this.tempMax.TabIndex = 5;
            this.tempMax.Text = "00 °";
            // 
            // tempMoy
            // 
            this.tempMoy.AutoSize = true;
            this.tempMoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempMoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tempMoy.Location = new System.Drawing.Point(115, 19);
            this.tempMoy.Name = "tempMoy";
            this.tempMoy.Size = new System.Drawing.Size(51, 25);
            this.tempMoy.TabIndex = 4;
            this.tempMoy.Text = "00 °";
            // 
            // tempMin
            // 
            this.tempMin.AutoSize = true;
            this.tempMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempMin.ForeColor = System.Drawing.Color.SteelBlue;
            this.tempMin.Location = new System.Drawing.Point(33, 19);
            this.tempMin.Name = "tempMin";
            this.tempMin.Size = new System.Drawing.Size(51, 25);
            this.tempMin.TabIndex = 3;
            this.tempMin.Text = "00 °";
            // 
            // tempMaxLabel
            // 
            this.tempMaxLabel.AutoSize = true;
            this.tempMaxLabel.Depth = 0;
            this.tempMaxLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.tempMaxLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tempMaxLabel.Location = new System.Drawing.Point(198, 0);
            this.tempMaxLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.tempMaxLabel.Name = "tempMaxLabel";
            this.tempMaxLabel.Size = new System.Drawing.Size(37, 19);
            this.tempMaxLabel.TabIndex = 2;
            this.tempMaxLabel.Text = "Max";
            // 
            // tempMoyLabel
            // 
            this.tempMoyLabel.AutoSize = true;
            this.tempMoyLabel.Depth = 0;
            this.tempMoyLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.tempMoyLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tempMoyLabel.Location = new System.Drawing.Point(116, 0);
            this.tempMoyLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.tempMoyLabel.Name = "tempMoyLabel";
            this.tempMoyLabel.Size = new System.Drawing.Size(38, 19);
            this.tempMoyLabel.TabIndex = 1;
            this.tempMoyLabel.Text = "Moy";
            // 
            // tempMinLabel
            // 
            this.tempMinLabel.AutoSize = true;
            this.tempMinLabel.Depth = 0;
            this.tempMinLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.tempMinLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.tempMinLabel.Location = new System.Drawing.Point(34, 0);
            this.tempMinLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.tempMinLabel.Name = "tempMinLabel";
            this.tempMinLabel.Size = new System.Drawing.Size(34, 19);
            this.tempMinLabel.TabIndex = 0;
            this.tempMinLabel.Text = "Min";
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
            this.label5.Location = new System.Drawing.Point(41, 56);
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
            this.term.Location = new System.Drawing.Point(106, 55);
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
            // panel5
            // 
            this.panel5.Controls.Add(this.graph);
            this.panel5.Location = new System.Drawing.Point(1, 172);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(617, 286);
            this.panel5.TabIndex = 3;
            // 
            // syntheseFormBindingSource
            // 
            this.syntheseFormBindingSource.DataSource = typeof(WindowsFormsApplication2.SyntheseForm);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.humiMax);
            this.panel4.Controls.Add(this.humiMoy);
            this.panel4.Controls.Add(this.humiMin);
            this.panel4.Controls.Add(this.materialLabel1);
            this.panel4.Controls.Add(this.materialLabel2);
            this.panel4.Controls.Add(this.materialLabel3);
            this.panel4.Location = new System.Drawing.Point(30, 117);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(288, 45);
            this.panel4.TabIndex = 6;
            // 
            // humiMax
            // 
            this.humiMax.AutoSize = true;
            this.humiMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humiMax.ForeColor = System.Drawing.Color.SteelBlue;
            this.humiMax.Location = new System.Drawing.Point(193, 19);
            this.humiMax.Name = "humiMax";
            this.humiMax.Size = new System.Drawing.Size(61, 25);
            this.humiMax.TabIndex = 5;
            this.humiMax.Text = "00 %";
            // 
            // humiMoy
            // 
            this.humiMoy.AutoSize = true;
            this.humiMoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humiMoy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.humiMoy.Location = new System.Drawing.Point(107, 19);
            this.humiMoy.Name = "humiMoy";
            this.humiMoy.Size = new System.Drawing.Size(61, 25);
            this.humiMoy.TabIndex = 4;
            this.humiMoy.Text = "00 %";
            // 
            // humiMin
            // 
            this.humiMin.AutoSize = true;
            this.humiMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.humiMin.ForeColor = System.Drawing.Color.Red;
            this.humiMin.Location = new System.Drawing.Point(22, 18);
            this.humiMin.Name = "humiMin";
            this.humiMin.Size = new System.Drawing.Size(61, 25);
            this.humiMin.TabIndex = 3;
            this.humiMin.Text = "00 %";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(203, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(37, 19);
            this.materialLabel1.TabIndex = 2;
            this.materialLabel1.Text = "Max";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(115, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(38, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Moy";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(29, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(34, 19);
            this.materialLabel3.TabIndex = 0;
            this.materialLabel3.Text = "Min";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(138, 164);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(78, 19);
            this.materialLabel4.TabIndex = 6;
            this.materialLabel4.Text = "Humiditée";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(417, 164);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(94, 19);
            this.materialLabel5.TabIndex = 7;
            this.materialLabel5.Text = "Température";
            // 
            // SyntheseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 470);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SyntheseForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.graph)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.syntheseFormBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart graph;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private MaterialSkin.Controls.MaterialLabel tempMinLabel;
        private System.Windows.Forms.Panel panel5;
        private MaterialSkin.Controls.MaterialLabel tempMaxLabel;
        private MaterialSkin.Controls.MaterialLabel tempMoyLabel;
        private System.Windows.Forms.Label tempMax;
        private System.Windows.Forms.Label tempMoy;
        private System.Windows.Forms.Label tempMin;
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label humiMax;
        private System.Windows.Forms.Label humiMoy;
        private System.Windows.Forms.Label humiMin;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}