using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2.Classes;

namespace WindowsFormsApplication2
{
    public partial class ExportForm : Form
    {
        public ExportForm()
        {
            InitializeComponent();
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                MainForm main = (MainForm)this.ParentForm;

                if (!cbExcel.Checked) return;

                SaveFileDialog saveFile = new SaveFileDialog();

                saveFile.DefaultExt = "csv";

                String name = main.getSensorName();
                name = Function.slugify(name);
                if (main.getSensorName() == "") name = "allSensor";
                saveFile.FileName = name;


                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    String stream = "";
                    String sensorId = main.getSensorId();
                    DateTime start = main.getStartDate();
                    DateTime end = main.getEndDate();

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
                    List<Dictionary<String, String>> results = null;

                    results = Database.select(query, parameters);


                    //Nom des colonnes sur la premiere ligne
                    foreach (KeyValuePair<String, String> cell in results[0])
                    {
                        stream += cell.Key + ";";
                    }

                    //Saut d'une ligne
                    stream += Environment.NewLine;

                    //Valeurs des lignes
                    foreach (Dictionary<String, String> row in results)
                    {
                        //Toutes les valeurs des cellules de la ligne courante
                        foreach (KeyValuePair<String, String> cell in row)
                        {
                            stream += cell.Value + ";";
                        }
                        stream += Environment.NewLine;
                    }



                    File.WriteAllText(saveFile.FileName, stream, Encoding.UTF8);
                    MessageBox.Show("Export effectué avec succès sur " + saveFile.FileName);
                    if (chkOpenFile.Checked) Process.Start(saveFile.FileName);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur Sql d'export" + ex.Message, "ERREUR", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur d'export" + ex.Message, "ERREUR", MessageBoxButtons.OK);
            }
        }
    }
}
