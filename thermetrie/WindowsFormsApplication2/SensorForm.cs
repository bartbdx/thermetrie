using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApplication2.Classes;

namespace WindowsFormsApplication2
{
    public partial class SensorForm : Form
    {
        public SensorForm()
        {
            InitializeComponent();
        }
        public void refreshSensor()
        {
            Form form = this.ParentForm;
            MainForm main = (MainForm)form;
            String sensor = main.getSensorId();
            dgSensor.Rows.Clear();
            txtLabel.Text = "";
            sensorWS.Text = "";
            sensorUID.Text = "";
            txtLabel.Tag = "";

            //Selection des données et des capteurs liés
            String query = "SELECT * FROM sensor";
            
            //Ajout des parametres échappés
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            if (sensor != "") parameters["@sensor"] = sensor;
           

            //Remplissage du datagridview
            foreach (Dictionary<String, String> line in Database.select(query, parameters))
            {
                DataGridViewRow row = new DataGridViewRow();
                //Set de l'id sur la ligne
                row.Tag = line["id"];
                //remplissage des cellules
                row.CreateCells(dgSensor, new object[] { line["label"], line["uid"], Properties.Resources.icon_edit, Properties.Resources.cross });
                //Ajout de la row au datagrid
                dgSensor.Rows.Add(row);
            }

        }        

        private void addSensor_Click(object sender, EventArgs e)
        {
            try
            {
                Dictionary<String, String> parameters = new Dictionary<string, string>();
                parameters["@label"] = txtLabel.Text;
                parameters["@uid"] = sensorUID.Text;
                parameters["@webservice"] = sensorWS.Text;

                if (txtLabel.Tag.ToString() != "")
                {
                    Database.quickExecute("UPDATE sensor SET label = @label , webservice = @webservice , uid = @uid WHERE sensor.id ="+ txtLabel.Tag.ToString() + " ;", parameters);
                    txtLabel.Tag = "";
                }else 
                {
                    
                    Database.quickExecute("INSERT INTO sensor (label,uid,webservice) VALUE (@label, @uid, @webservice);", parameters);
                    txtLabel.Tag = "";
                }
            }
            catch
            {

            }
            refreshSensor();
        }

        private void dgSensor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                
                DialogResult result = MessageBox.Show("Êtes vous sur de vouloir supprimer cette ligne ?", "Supression de ligne", MessageBoxButtons.YesNo);
                if (result == DialogResult.No) return;
                int id = Convert.ToUInt16(dgSensor.Rows[e.RowIndex].Tag);
                try
                {
                    Database.quickExecute("DELETE FROM sensor WHERE id = @id", new Dictionary<string, string>() { { "@id", id.ToString() } });

                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Erreur Sql d'export" + ex.Message, "ERREUR", MessageBoxButtons.OK);

                    return;
                }
                dgSensor.Rows.RemoveAt(e.RowIndex);
                refreshSensor();
            }
            else if (e.ColumnIndex == 2)
            {
                int id = Convert.ToUInt16(dgSensor.Rows[e.RowIndex].Tag);
                List<Dictionary<String, String>> line = Database.select("SELECT * FROM sensor WHERE id = " + id);
                txtLabel.Text = line[0]["label"];
                sensorUID.Text = line[0]["uid"];
                sensorWS.Text = line[0]["webservice"];
                txtLabel.Tag = line[0]["id"];
               
            }
        }

        

        private void refreshSensorButton_Click(object sender, EventArgs e)
        {
            refreshSensor();
        }
    }
}
           
       
