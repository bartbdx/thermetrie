namespace WindowsFormsApplication2
{
    partial class ExportForm
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
            this.chkMailFile = new MaterialSkin.Controls.MaterialCheckBox();
            this.cbPDF = new MaterialSkin.Controls.MaterialRadioButton();
            this.cbExcel = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnExport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.chkOpenFile = new MaterialSkin.Controls.MaterialCheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkMailFile
            // 
            this.chkMailFile.AutoSize = true;
            this.chkMailFile.Depth = 0;
            this.chkMailFile.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkMailFile.Location = new System.Drawing.Point(28, 184);
            this.chkMailFile.Margin = new System.Windows.Forms.Padding(0);
            this.chkMailFile.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkMailFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkMailFile.Name = "chkMailFile";
            this.chkMailFile.Ripple = true;
            this.chkMailFile.Size = new System.Drawing.Size(239, 30);
            this.chkMailFile.TabIndex = 3;
            this.chkMailFile.Text = "Envoyer par mail après génération";
            this.chkMailFile.UseVisualStyleBackColor = true;
            // 
            // cbPDF
            // 
            this.cbPDF.AutoSize = true;
            this.cbPDF.Depth = 0;
            this.cbPDF.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbPDF.Location = new System.Drawing.Point(33, 90);
            this.cbPDF.Margin = new System.Windows.Forms.Padding(0);
            this.cbPDF.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbPDF.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbPDF.Name = "cbPDF";
            this.cbPDF.Ripple = true;
            this.cbPDF.Size = new System.Drawing.Size(54, 30);
            this.cbPDF.TabIndex = 4;
            this.cbPDF.TabStop = true;
            this.cbPDF.Text = "PDF";
            this.cbPDF.UseVisualStyleBackColor = true;
            // 
            // cbExcel
            // 
            this.cbExcel.AutoSize = true;
            this.cbExcel.Depth = 0;
            this.cbExcel.Font = new System.Drawing.Font("Roboto", 10F);
            this.cbExcel.Location = new System.Drawing.Point(132, 90);
            this.cbExcel.Margin = new System.Windows.Forms.Padding(0);
            this.cbExcel.MouseLocation = new System.Drawing.Point(-1, -1);
            this.cbExcel.MouseState = MaterialSkin.MouseState.HOVER;
            this.cbExcel.Name = "cbExcel";
            this.cbExcel.Ripple = true;
            this.cbExcel.Size = new System.Drawing.Size(70, 30);
            this.cbExcel.TabIndex = 5;
            this.cbExcel.TabStop = true;
            this.cbExcel.Text = "EXCEL";
            this.cbExcel.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Depth = 0;
            this.btnExport.Location = new System.Drawing.Point(12, 300);
            this.btnExport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExport.Name = "btnExport";
            this.btnExport.Primary = true;
            this.btnExport.Size = new System.Drawing.Size(456, 44);
            this.btnExport.TabIndex = 6;
            this.btnExport.Text = "Exporter";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // chkOpenFile
            // 
            this.chkOpenFile.AutoSize = true;
            this.chkOpenFile.Depth = 0;
            this.chkOpenFile.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkOpenFile.Location = new System.Drawing.Point(28, 219);
            this.chkOpenFile.Margin = new System.Windows.Forms.Padding(0);
            this.chkOpenFile.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkOpenFile.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkOpenFile.Name = "chkOpenFile";
            this.chkOpenFile.Ripple = true;
            this.chkOpenFile.Size = new System.Drawing.Size(174, 30);
            this.chkOpenFile.TabIndex = 10;
            this.chkOpenFile.Text = "Ouvrir après génération";
            this.chkOpenFile.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(24, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "FORMAT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(24, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "OPTIONS";
            // 
            // ExportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 356);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkOpenFile);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.cbExcel);
            this.Controls.Add(this.cbPDF);
            this.Controls.Add(this.chkMailFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExportForm";
            this.Text = "exportForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialCheckBox chkMailFile;
        private MaterialSkin.Controls.MaterialRadioButton cbPDF;
        private MaterialSkin.Controls.MaterialRadioButton cbExcel;
        private MaterialSkin.Controls.MaterialRaisedButton btnExport;
        private MaterialSkin.Controls.MaterialCheckBox chkOpenFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}