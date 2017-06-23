using MySql.Data.MySqlClient;
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
    public partial class DataForm : Form
    {
        List<String> erreur = new List<String>(new String[] { "" });
        String ligneErreur = "";



        public DataForm()
        {
            InitializeComponent();
        }

        public void refreshData()
        {
            Form form = this.ParentForm;
            MainForm main = (MainForm)form;
            String sensorId = main.getSensorId();
            DateTime start = main.getStartDate();
            DateTime end = main.getEndDate();

            dgData.Rows.Clear();

            //Selection des données et des capteurs liés
            String query = "SELECT s.label,s.uid,d.* from data d INNER JOIN sensor s ON s.id = d.sensor_id WHERE 1 ";
            //Ajout  filtre par capteur si un capteur est sélectionné
            if (sensorId != "") query += "AND sensor_id=@sensorId ";
            //Ajout date de début / date de fin
            query += " AND (data_date BETWEEN @start AND @end)";
            // Par ordre de date ascendante / capteur
            query += " ORDER BY d.data_date DESC,sensor_id";

            //Ajout des parametres échappés
            Dictionary<String, String> parameters = new Dictionary<string, string>();
            if (sensorId != "") parameters["@sensorId"] = sensorId;
            parameters["@start"] = start.ToString("yyyy-MM-dd HH:mm:ss");
            parameters["@end"] = end.ToString("yyyy-MM-dd HH:mm:ss");

            //Remplissage du datagridview
            foreach (Dictionary<String, String> line in Database.select(query, parameters))
            {
                DataGridViewRow row = new DataGridViewRow();
                //Set de l'id sur la ligne
                row.Tag = line["id"];
                //remplissage des cellules
                row.CreateCells(dgData, new object[] { line["data_date"], line["label"], line["uid"], line["humidity"], line["temperature"], Properties.Resources.cross });
                //Ajout de la row au datagrid
                dgData.Rows.Add(row);
            }

        }

        private void dgData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 5) return;
            DialogResult result = MessageBox.Show("Êtes vous sur de vouloir supprimer cette ligne ?", "Supression de ligne", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;
            int id = Convert.ToUInt16(dgData.Rows[e.RowIndex].Tag);
            try
            {
                Database.quickExecute("DELETE FROM data WHERE sensor_id = @id", new Dictionary<string, string>() { { "@id", id.ToString() } });

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur Sql d'export" + ex.Message, "ERREUR", MessageBoxButtons.OK);

                return;
            }

            dgData.Rows.RemoveAt(e.RowIndex);
        }

        private void dgData_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {


            try
            {
                String id = (String)e.Row.Tag;
                Database.quickExecute("DELETE FROM data WHERE id = @id", new Dictionary<string, string>() { { "@id", id } });
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Erreur d'export" + ex.Message, "ERREUR", MessageBoxButtons.OK);
                erreur.Add(" ligne " + (e.Row.Index + 1));
                errorList.Text = string.Join(",", erreur);
                e.Cancel = true;
            }
        }

        private void dgData_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete) return;
            DialogResult result = MessageBox.Show("Êtes vous sur de vouloir supprimer cette ligne ?", "Supression de ligne", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) e.Handled = true;
        }
    }
}
