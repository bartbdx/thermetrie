
using MaterialSkin;
using MaterialSkin.Controls;
using SensorBoard;
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
    public partial class MainForm : MaterialForm
    {
        ImportForm import;
        ExportForm export;
        DataForm data;
        ConfigurationForm configuration;
        SyntForm synthesis;

        public MainForm()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue600, Primary.Blue600, Accent.LightBlue200, TextShade.WHITE);

            //Instantiation du formulaire enfant
            import = new ImportForm();
            //Définition en formulaire inclus
            import.TopLevel = false;
            //Agrandissement à la taille du panel conteneur
            import.Dock = DockStyle.Fill;
            //Ajout du formulaire au panel principal
            plContent.Controls.Add(import);

            //Idem pour les autres formulaires
            data = new DataForm();
            data.TopLevel = false;
            data.Dock = DockStyle.Fill;
            plContent.Controls.Add(data);

            //Idem pour les autres formulaires
            synthesis = new SyntForm();
            synthesis.TopLevel = false;
            synthesis.Dock = DockStyle.Fill;
            plContent.Controls.Add(synthesis);

            //Idem pour les autres formulaires
            export = new ExportForm();
            export.TopLevel = false;
            export.Dock = DockStyle.Fill;
            plContent.Controls.Add(export);

            //Idem pour les autres formulaires
            configuration = new ConfigurationForm();
            configuration.TopLevel = false;
            configuration.Dock = DockStyle.Fill;
            plContent.Controls.Add(configuration);

            //Idem pour les autres formulaires
            data = new DataForm();
            data.TopLevel = false;
            data.Dock = DockStyle.Fill;
            plContent.Controls.Add(data);

            synthesis.Show();

            Dictionary<String, String> parameters = new Dictionary<String, String>();
        
            List<Dictionary<String, String>> lines = Database.select("SELECT id,label FROM sensor",parameters);

            cbSensor.DisplayMember = "Text";
            cbSensor.ValueMember = "Name";
            foreach (Dictionary<String,String> line in lines)
            {
                MenuItem item = new MenuItem();
                item.Text = line["label"];
                item.Name = line["id"];
                cbSensor.Items.Add(item);
            }

        }

        private void loadImport(object sender, EventArgs e)
        {
            hideForms();
            import.Show();
        }


        private void btnData_Click(object sender, EventArgs e)
        {
            hideForms();
            data.Show();
        }

        /// <summary>
        /// Retourne la valeur du capteur sélectionné
        /// </summary>
        /// <returns></returns>
        public String getSensor()
        {
            if (cbSensor.SelectedItem == null) return "";
            MenuItem item = (MenuItem)cbSensor.SelectedItem;
            return item.Name;
        }


        /// <summary>
        /// Cache les formulaire
        /// </summary>
        private void hideForms()
        {
            foreach (Control form in plContent.Controls)
                form.Hide();
        }

        private void btnSynthesis_Click(object sender, EventArgs e)
        {
            hideForms();
            synthesis.Show();
        }

        private void btnRapport_Click(object sender, EventArgs e)
        {
            hideForms();
            export.Show();
        }

        private void btnConfiguration_Click(object sender, EventArgs e)
        {
            hideForms();
            configuration.Show();
        }
    }
 }
