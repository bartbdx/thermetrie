namespace WindowsFormsApplication2
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnConfiguration = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnRapport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnData = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnImport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSynthesis = new MaterialSkin.Controls.MaterialRaisedButton();
            this.plContent = new System.Windows.Forms.Panel();
            this.cbSensor = new System.Windows.Forms.ComboBox();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.sensorConf = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.25F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.plContent, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 480F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 480F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 480);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.panel1.Controls.Add(this.btnConfiguration);
            this.panel1.Controls.Add(this.btnRapport);
            this.panel1.Controls.Add(this.btnData);
            this.panel1.Controls.Add(this.btnImport);
            this.panel1.Controls.Add(this.btnSynthesis);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(174, 480);
            this.panel1.TabIndex = 0;
            // 
            // btnConfiguration
            // 
            this.btnConfiguration.Depth = 0;
            this.btnConfiguration.Location = new System.Drawing.Point(7, 194);
            this.btnConfiguration.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfiguration.Name = "btnConfiguration";
            this.btnConfiguration.Primary = true;
            this.btnConfiguration.Size = new System.Drawing.Size(160, 39);
            this.btnConfiguration.TabIndex = 4;
            this.btnConfiguration.Text = "CONFIGURATION";
            this.btnConfiguration.UseVisualStyleBackColor = true;
            this.btnConfiguration.Click += new System.EventHandler(this.btnConfiguration_Click);
            // 
            // btnRapport
            // 
            this.btnRapport.Depth = 0;
            this.btnRapport.Location = new System.Drawing.Point(7, 59);
            this.btnRapport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRapport.Name = "btnRapport";
            this.btnRapport.Primary = true;
            this.btnRapport.Size = new System.Drawing.Size(160, 39);
            this.btnRapport.TabIndex = 3;
            this.btnRapport.Text = "RAPPORT";
            this.btnRapport.UseVisualStyleBackColor = true;
            this.btnRapport.Click += new System.EventHandler(this.btnRapport_Click);
            // 
            // btnData
            // 
            this.btnData.Depth = 0;
            this.btnData.Location = new System.Drawing.Point(7, 104);
            this.btnData.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnData.Name = "btnData";
            this.btnData.Primary = true;
            this.btnData.Size = new System.Drawing.Size(160, 39);
            this.btnData.TabIndex = 2;
            this.btnData.Text = "DONNES";
            this.btnData.UseVisualStyleBackColor = true;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnImport
            // 
            this.btnImport.Depth = 0;
            this.btnImport.Location = new System.Drawing.Point(7, 149);
            this.btnImport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImport.Name = "btnImport";
            this.btnImport.Primary = true;
            this.btnImport.Size = new System.Drawing.Size(160, 39);
            this.btnImport.TabIndex = 1;
            this.btnImport.Text = "IMPORT";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.loadImport);
            // 
            // btnSynthesis
            // 
            this.btnSynthesis.Depth = 0;
            this.btnSynthesis.Location = new System.Drawing.Point(7, 14);
            this.btnSynthesis.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSynthesis.Name = "btnSynthesis";
            this.btnSynthesis.Primary = true;
            this.btnSynthesis.Size = new System.Drawing.Size(160, 39);
            this.btnSynthesis.TabIndex = 0;
            this.btnSynthesis.Text = "SYNTHESE";
            this.btnSynthesis.UseVisualStyleBackColor = true;
            this.btnSynthesis.Click += new System.EventHandler(this.btnSynthesis_Click);
            // 
            // plContent
            // 
            this.plContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plContent.Location = new System.Drawing.Point(177, 3);
            this.plContent.Name = "plContent";
            this.plContent.Size = new System.Drawing.Size(620, 474);
            this.plContent.TabIndex = 1;
            // 
            // cbSensor
            // 
            this.cbSensor.FormattingEnabled = true;
            this.cbSensor.Location = new System.Drawing.Point(149, 32);
            this.cbSensor.Name = "cbSensor";
            this.cbSensor.Size = new System.Drawing.Size(124, 21);
            this.cbSensor.TabIndex = 1;
            this.cbSensor.SelectedIndexChanged += new System.EventHandler(this.cbSensor_SelectedIndexChanged);
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(588, 33);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(166, 20);
            this.dtEnd.TabIndex = 2;
            this.dtEnd.ValueChanged += new System.EventHandler(this.cbSensor_SelectedIndexChanged);
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(385, 33);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(165, 20);
            this.dtStart.TabIndex = 3;
            this.dtStart.ValueChanged += new System.EventHandler(this.cbSensor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(355, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "De";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(562, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "à";
            // 
            // sensorConf
            // 
            this.sensorConf.Location = new System.Drawing.Point(79, 31);
            this.sensorConf.Name = "sensorConf";
            this.sensorConf.Size = new System.Drawing.Size(58, 23);
            this.sensorConf.TabIndex = 7;
            this.sensorConf.Text = "Capteur";
            this.sensorConf.UseVisualStyleBackColor = true;
            this.sensorConf.Click += new System.EventHandler(this.sensorConf_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(3, 2);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(95, 20);
            this.Title.TabIndex = 8;
            this.Title.Text = "Thermetrie";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 540);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.sensorConf);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtStart);
            this.Controls.Add(this.dtEnd);
            this.Controls.Add(this.cbSensor);
            this.Controls.Add(this.tableLayoutPanel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "MainForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialRaisedButton btnData;
        private MaterialSkin.Controls.MaterialRaisedButton btnImport;
        private MaterialSkin.Controls.MaterialRaisedButton btnSynthesis;
        private MaterialSkin.Controls.MaterialRaisedButton btnRapport;
        private MaterialSkin.Controls.MaterialRaisedButton btnConfiguration;
        private System.Windows.Forms.Panel plContent;
        private System.Windows.Forms.ComboBox cbSensor;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button sensorConf;
        private System.Windows.Forms.Label Title;
    }
}

