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
    public partial class ImportForm : Form
    {
        public ImportForm()
        {
            InitializeComponent();
        }

        private void btnImportFile_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog filePicker = new OpenFileDialog();
                Form parent = this.ParentForm;



                if (filePicker.ShowDialog() == DialogResult.OK)
                {
                    MySqlConnection connection = new MySqlConnection("SERVER=" + Function.ReadSetting("bddAddress") 
                        + ";DATABASE=" + Function.ReadSetting("bddName") + ";UID=" + Function.ReadSetting("bddLogin") 
                        + ";PASSWORD=" + Function.ReadSetting("bddPassword") + ";CharSet=utf8;");
                    try
                    {
                        connection.Open();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erreur de connexion à la base de donnée: " + ex.Message);
                    }
                    Form form = this.ParentForm;
                    MainForm main = (MainForm)form;
                    String sensorId = main.getSensorId();

                    if (sensorId == "") throw new Exception("Merci de sélectionner un capteur");
                    if (!File.Exists(filePicker.FileName)) throw new Exception("Fichier inexistant");


                    long finfo = new FileInfo(filePicker.FileName).Length;
                    if (finfo == 0) throw new Exception("Fichier vide");

                    String[] lines = File.ReadAllLines(filePicker.FileName);

                    for (int lineNumber = 0; lineNumber < lines.Length; lineNumber++)
                    {
                        String[] columns = lines[lineNumber].Split(' ');
                        if (columns.Length != 5) throw new Exception("Une erreur L " + lineNumber + " !");
                    }



                    Database db = new Database();
                    db.connect();
                    foreach (String line in lines)
                    {
                        String[] columns = line.Split(' ');
                        String humidity = Regex.Replace(columns[4], "%", "");
                        String temperature = columns[3];
                        String dataDate = columns[1] + " " + columns[2];

                        String[] test = new String[] { "1", "2", "3", "4" };

                        db.execute("INSERT INTO data (sensor_id,humidity,temperature,import_date,data_date)VALUES(@sensorId,@humidity,@temperature,@import_date,@data_date)",
                            new Dictionary<String, String>() {
                                { "@humidity", humidity },
                                { "@data_date", dataDate },
                                { "@import_date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") },
                                { "@sensorId", sensorId },
                                { "@temperature", temperature },
                            });

                    }
                    db.disconnect();
                    MessageBox.Show("Données importées");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR: " + ex.Message);
            }
        }
    }
}
