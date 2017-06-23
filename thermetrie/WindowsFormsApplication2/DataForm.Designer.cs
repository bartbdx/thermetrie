namespace WindowsFormsApplication2
{
    partial class DataForm
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
            this.dgData = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorList = new System.Windows.Forms.Label();
            this.dataDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sensor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgData
            // 
            this.dgData.AllowUserToAddRows = false;
            this.dgData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgData.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.dgData.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataDate,
            this.sensor,
            this.uid,
            this.humidity,
            this.temperature,
            this.delete});
            this.dgData.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgData.Location = new System.Drawing.Point(0, 90);
            this.dgData.Name = "dgData";
            this.dgData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgData.ShowEditingIcon = false;
            this.dgData.Size = new System.Drawing.Size(620, 384);
            this.dgData.TabIndex = 0;
            this.dgData.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgData_CellClick);
            this.dgData.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dgData_UserDeletingRow);
            this.dgData.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgData_KeyDown);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorList
            // 
            this.errorList.Dock = System.Windows.Forms.DockStyle.Top;
            this.errorList.Location = new System.Drawing.Point(0, 0);
            this.errorList.Name = "errorList";
            this.errorList.Size = new System.Drawing.Size(620, 32);
            this.errorList.TabIndex = 1;
            this.errorList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataDate
            // 
            this.dataDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataDate.FillWeight = 120F;
            this.dataDate.HeaderText = "Date des données";
            this.dataDate.MinimumWidth = 120;
            this.dataDate.Name = "dataDate";
            this.dataDate.ReadOnly = true;
            this.dataDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataDate.Width = 120;
            // 
            // sensor
            // 
            this.sensor.HeaderText = "Capteur";
            this.sensor.MinimumWidth = 100;
            this.sensor.Name = "sensor";
            this.sensor.ReadOnly = true;
            // 
            // uid
            // 
            this.uid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.uid.FillWeight = 140F;
            this.uid.HeaderText = "UID Capteur";
            this.uid.MinimumWidth = 140;
            this.uid.Name = "uid";
            this.uid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.uid.Width = 140;
            // 
            // humidity
            // 
            this.humidity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.humidity.FillWeight = 50F;
            this.humidity.HeaderText = "Humidité";
            this.humidity.MinimumWidth = 50;
            this.humidity.Name = "humidity";
            this.humidity.ReadOnly = true;
            this.humidity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.humidity.Width = 50;
            // 
            // temperature
            // 
            this.temperature.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.temperature.FillWeight = 50F;
            this.temperature.HeaderText = "Temp";
            this.temperature.MinimumWidth = 50;
            this.temperature.Name = "temperature";
            this.temperature.ReadOnly = true;
            this.temperature.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.temperature.Width = 50;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.delete.FillWeight = 45F;
            this.delete.HeaderText = "Supp";
            this.delete.MinimumWidth = 45;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delete.Width = 45;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 474);
            this.Controls.Add(this.errorList);
            this.Controls.Add(this.dgData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DataForm";
            this.Text = "DataForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgData;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label errorList;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn sensor;
        private System.Windows.Forms.DataGridViewTextBoxColumn uid;
        private System.Windows.Forms.DataGridViewTextBoxColumn humidity;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperature;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}