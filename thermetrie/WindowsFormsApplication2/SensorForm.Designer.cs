namespace WindowsFormsApplication2
{
    partial class SensorForm
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
            this.dgSensor = new System.Windows.Forms.DataGridView();
            this.addSensor = new MaterialSkin.Controls.MaterialRaisedButton();
            this.sensorWS = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtLabel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.sensorUID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.label = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.refreshSensorButton = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgSensor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgSensor
            // 
            this.dgSensor.AllowUserToAddRows = false;
            this.dgSensor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgSensor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSensor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.label,
            this.uid,
            this.edit,
            this.delete});
            this.dgSensor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgSensor.Location = new System.Drawing.Point(0, 289);
            this.dgSensor.Name = "dgSensor";
            this.dgSensor.RowHeadersVisible = false;
            this.dgSensor.ShowCellErrors = false;
            this.dgSensor.Size = new System.Drawing.Size(620, 185);
            this.dgSensor.TabIndex = 0;
            this.dgSensor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSensor_CellClick);
            // 
            // addSensor
            // 
            this.addSensor.Depth = 0;
            this.addSensor.Location = new System.Drawing.Point(263, 238);
            this.addSensor.MouseState = MaterialSkin.MouseState.HOVER;
            this.addSensor.Name = "addSensor";
            this.addSensor.Primary = true;
            this.addSensor.Size = new System.Drawing.Size(103, 23);
            this.addSensor.TabIndex = 1;
            this.addSensor.Text = "Enregistrer";
            this.addSensor.UseVisualStyleBackColor = true;
            this.addSensor.Click += new System.EventHandler(this.addSensor_Click);
            // 
            // sensorWS
            // 
            this.sensorWS.Depth = 0;
            this.sensorWS.Hint = "";
            this.sensorWS.Location = new System.Drawing.Point(201, 180);
            this.sensorWS.Margin = new System.Windows.Forms.Padding(0);
            this.sensorWS.MouseState = MaterialSkin.MouseState.HOVER;
            this.sensorWS.Name = "sensorWS";
            this.sensorWS.PasswordChar = '\0';
            this.sensorWS.SelectedText = "";
            this.sensorWS.SelectionLength = 0;
            this.sensorWS.SelectionStart = 0;
            this.sensorWS.Size = new System.Drawing.Size(278, 23);
            this.sensorWS.TabIndex = 2;
            this.sensorWS.Text = "WebService";
            this.sensorWS.UseSystemPasswordChar = false;
            // 
            // txtLabel
            // 
            this.txtLabel.Depth = 0;
            this.txtLabel.Hint = "";
            this.txtLabel.Location = new System.Drawing.Point(201, 42);
            this.txtLabel.Margin = new System.Windows.Forms.Padding(0);
            this.txtLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLabel.Name = "txtLabel";
            this.txtLabel.PasswordChar = '\0';
            this.txtLabel.SelectedText = "";
            this.txtLabel.SelectionLength = 0;
            this.txtLabel.SelectionStart = 0;
            this.txtLabel.Size = new System.Drawing.Size(278, 23);
            this.txtLabel.TabIndex = 3;
            this.txtLabel.Text = "Capteur ";
            this.txtLabel.UseSystemPasswordChar = false;
            // 
            // sensorUID
            // 
            this.sensorUID.Depth = 0;
            this.sensorUID.Hint = "";
            this.sensorUID.Location = new System.Drawing.Point(201, 114);
            this.sensorUID.Margin = new System.Windows.Forms.Padding(0);
            this.sensorUID.MouseState = MaterialSkin.MouseState.HOVER;
            this.sensorUID.Name = "sensorUID";
            this.sensorUID.PasswordChar = '\0';
            this.sensorUID.SelectedText = "";
            this.sensorUID.SelectionLength = 0;
            this.sensorUID.SelectionStart = 0;
            this.sensorUID.Size = new System.Drawing.Size(278, 23);
            this.sensorUID.TabIndex = 4;
            this.sensorUID.Text = "UID";
            this.sensorUID.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(61, 42);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(124, 19);
            this.materialLabel1.TabIndex = 5;
            this.materialLabel1.Text = "Nom du capteur :";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(66, 118);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(119, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "UID du capteur : ";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 180);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(173, 19);
            this.materialLabel3.TabIndex = 7;
            this.materialLabel3.Text = "WebService (Optionnel) :";
            // 
            // label
            // 
            this.label.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.label.HeaderText = "Nom du capteur";
            this.label.Name = "label";
            this.label.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // uid
            // 
            this.uid.HeaderText = "UID";
            this.uid.Name = "uid";
            this.uid.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.uid.Width = 250;
            // 
            // edit
            // 
            this.edit.HeaderText = "Modifier";
            this.edit.Name = "edit";
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.edit.Width = 70;
            // 
            // delete
            // 
            this.delete.HeaderText = "Supprimer";
            this.delete.Name = "delete";
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delete.Width = 70;
            // 
            // refreshSensorButton
            // 
            this.refreshSensorButton.Depth = 0;
            this.refreshSensorButton.Location = new System.Drawing.Point(114, 238);
            this.refreshSensorButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.refreshSensorButton.Name = "refreshSensorButton";
            this.refreshSensorButton.Primary = true;
            this.refreshSensorButton.Size = new System.Drawing.Size(143, 23);
            this.refreshSensorButton.TabIndex = 8;
            this.refreshSensorButton.Text = "Nouveau Capteur";
            this.refreshSensorButton.UseVisualStyleBackColor = true;
            this.refreshSensorButton.Click += new System.EventHandler(this.refreshSensorButton_Click);
            // 
            // SensorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 474);
            this.Controls.Add(this.refreshSensorButton);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.sensorUID);
            this.Controls.Add(this.txtLabel);
            this.Controls.Add(this.sensorWS);
            this.Controls.Add(this.addSensor);
            this.Controls.Add(this.dgSensor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SensorForm";
            this.Text = "ImportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgSensor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSensor;
        private MaterialSkin.Controls.MaterialRaisedButton addSensor;
        private MaterialSkin.Controls.MaterialSingleLineTextField sensorWS;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField sensorUID;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private System.Windows.Forms.DataGridViewTextBoxColumn label;
        private System.Windows.Forms.DataGridViewTextBoxColumn uid;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private MaterialSkin.Controls.MaterialRaisedButton refreshSensorButton;
    }
}