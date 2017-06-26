using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.Classes;

namespace WindowsFormsApplication2
{
    public partial class ConfigurationForm : Form
    {
        public ConfigurationForm()
        {
            InitializeComponent();
        }
        public void refreshConfig()
        {
            //Function.ReadAllSettings();
            AdresseBDDField.Text = Function.ReadSetting("bddAddress");
            NameBDDField.Text = Function.ReadSetting("bddName");
            LoginBDDField.Text = Function.ReadSetting("bddLogin");
            MDPBDDField.Text = Function.ReadSetting("bddPassword");
            PathExportFileField.Text = Function.ReadSetting("pathExport");
            ExportMailAddField.Text = Function.ReadSetting("mailExport");
        }

        private void reInitButton_Click(object sender, EventArgs e)
        {
            refreshConfig();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Function.AddUpdateAppSettings("bddAddress", AdresseBDDField.Text);
            Function.AddUpdateAppSettings("bddName", NameBDDField.Text);
            Function.AddUpdateAppSettings("bddLogin", LoginBDDField.Text);
            Function.AddUpdateAppSettings("bddPassword", MDPBDDField.Text);
            Function.AddUpdateAppSettings("pathExport", PathExportFileField.Text);
            Function.AddUpdateAppSettings("mailExport", ExportMailAddField.Text);
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
