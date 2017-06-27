namespace WindowsFormsApplication2
{
    partial class ConfigurationForm
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
            this.saveButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.reInitButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Config_Mail = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ExportMailAddField = new System.Windows.Forms.TextBox();
            this.PathExportFileField = new System.Windows.Forms.TextBox();
            this.Config_BDD = new System.Windows.Forms.TabPage();
            this.NameBDDField = new System.Windows.Forms.TextBox();
            this.LoginBDDField = new System.Windows.Forms.TextBox();
            this.MDPBDDField = new System.Windows.Forms.TextBox();
            this.AdresseBDDField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.Config_Mail.SuspendLayout();
            this.Config_BDD.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Depth = 0;
            this.saveButton.Location = new System.Drawing.Point(322, 422);
            this.saveButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.saveButton.Name = "saveButton";
            this.saveButton.Primary = true;
            this.saveButton.Size = new System.Drawing.Size(130, 36);
            this.saveButton.TabIndex = 15;
            this.saveButton.Text = "Sauvegarder";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // reInitButton
            // 
            this.reInitButton.Depth = 0;
            this.reInitButton.Location = new System.Drawing.Point(184, 422);
            this.reInitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.reInitButton.Name = "reInitButton";
            this.reInitButton.Primary = true;
            this.reInitButton.Size = new System.Drawing.Size(132, 36);
            this.reInitButton.TabIndex = 16;
            this.reInitButton.Text = "Reinitialiser";
            this.reInitButton.UseVisualStyleBackColor = true;
            this.reInitButton.Click += new System.EventHandler(this.reInitButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Config_Mail);
            this.tabControl1.Controls.Add(this.Config_BDD);
            this.tabControl1.Location = new System.Drawing.Point(3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(626, 414);
            this.tabControl1.TabIndex = 17;
            // 
            // Config_Mail
            // 
            this.Config_Mail.Controls.Add(this.label5);
            this.Config_Mail.Controls.Add(this.label9);
            this.Config_Mail.Controls.Add(this.ExportMailAddField);
            this.Config_Mail.Controls.Add(this.PathExportFileField);
            this.Config_Mail.Location = new System.Drawing.Point(4, 22);
            this.Config_Mail.Name = "Config_Mail";
            this.Config_Mail.Padding = new System.Windows.Forms.Padding(3);
            this.Config_Mail.Size = new System.Drawing.Size(618, 388);
            this.Config_Mail.TabIndex = 0;
            this.Config_Mail.Text = "Configuration Mail";
            this.Config_Mail.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Chemin dossier export";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(341, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Mail export( separateur \";\")";
            // 
            // ExportMailAddField
            // 
            this.ExportMailAddField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportMailAddField.Location = new System.Drawing.Point(345, 41);
            this.ExportMailAddField.Name = "ExportMailAddField";
            this.ExportMailAddField.Size = new System.Drawing.Size(265, 23);
            this.ExportMailAddField.TabIndex = 1;
            // 
            // PathExportFileField
            // 
            this.PathExportFileField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PathExportFileField.Location = new System.Drawing.Point(13, 41);
            this.PathExportFileField.Name = "PathExportFileField";
            this.PathExportFileField.Size = new System.Drawing.Size(266, 23);
            this.PathExportFileField.TabIndex = 0;
            // 
            // Config_BDD
            // 
            this.Config_BDD.Controls.Add(this.label11);
            this.Config_BDD.Controls.Add(this.label10);
            this.Config_BDD.Controls.Add(this.label8);
            this.Config_BDD.Controls.Add(this.label4);
            this.Config_BDD.Controls.Add(this.AdresseBDDField);
            this.Config_BDD.Controls.Add(this.MDPBDDField);
            this.Config_BDD.Controls.Add(this.LoginBDDField);
            this.Config_BDD.Controls.Add(this.NameBDDField);
            this.Config_BDD.Location = new System.Drawing.Point(4, 22);
            this.Config_BDD.Name = "Config_BDD";
            this.Config_BDD.Padding = new System.Windows.Forms.Padding(3);
            this.Config_BDD.Size = new System.Drawing.Size(618, 388);
            this.Config_BDD.TabIndex = 1;
            this.Config_BDD.Text = "Configuration BDD";
            this.Config_BDD.UseVisualStyleBackColor = true;
            // 
            // NameBDDField
            // 
            this.NameBDDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBDDField.Location = new System.Drawing.Point(10, 125);
            this.NameBDDField.Name = "NameBDDField";
            this.NameBDDField.Size = new System.Drawing.Size(201, 23);
            this.NameBDDField.TabIndex = 0;
            // 
            // LoginBDDField
            // 
            this.LoginBDDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBDDField.Location = new System.Drawing.Point(268, 44);
            this.LoginBDDField.Name = "LoginBDDField";
            this.LoginBDDField.Size = new System.Drawing.Size(177, 23);
            this.LoginBDDField.TabIndex = 1;
            // 
            // MDPBDDField
            // 
            this.MDPBDDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MDPBDDField.Location = new System.Drawing.Point(269, 125);
            this.MDPBDDField.Name = "MDPBDDField";
            this.MDPBDDField.Size = new System.Drawing.Size(177, 23);
            this.MDPBDDField.TabIndex = 2;
            // 
            // AdresseBDDField
            // 
            this.AdresseBDDField.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdresseBDDField.Location = new System.Drawing.Point(10, 44);
            this.AdresseBDDField.Name = "AdresseBDDField";
            this.AdresseBDDField.Size = new System.Drawing.Size(201, 23);
            this.AdresseBDDField.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Adresse de la BDD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nom de la BDD";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(265, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 20);
            this.label10.TabIndex = 6;
            this.label10.Text = "Login";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(265, 102);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "M.D.P";
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 470);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.reInitButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfigurationForm";
            this.Text = "ConfigurationForm";
            this.tabControl1.ResumeLayout(false);
            this.Config_Mail.ResumeLayout(false);
            this.Config_Mail.PerformLayout();
            this.Config_BDD.ResumeLayout(false);
            this.Config_BDD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialRaisedButton saveButton;
        private MaterialSkin.Controls.MaterialRaisedButton reInitButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Config_Mail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ExportMailAddField;
        private System.Windows.Forms.TextBox PathExportFileField;
        private System.Windows.Forms.TabPage Config_BDD;
        private System.Windows.Forms.TextBox AdresseBDDField;
        private System.Windows.Forms.TextBox MDPBDDField;
        private System.Windows.Forms.TextBox LoginBDDField;
        private System.Windows.Forms.TextBox NameBDDField;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
    }
}