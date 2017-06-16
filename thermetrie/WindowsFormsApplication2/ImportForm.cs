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
                    MySqlConnection connection = new MySqlConnection("SERVER=localhost;DATABASE=sensorboard2;UID=sensorboard2;PASSWORD=sensor;");

                    try
                    {
                        connection.Open();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Erreur de connexion à la base de donnée: " + ex.Message);
                    }

                    MySqlTransaction transaction = connection.BeginTransaction();

                    Form form = this.ParentForm;
                    MainForm main = (MainForm)form;
                    String sensor = main.getSensor();

                    if (sensor == "") throw new Exception("Merci de sélectionner un capteur");
                    if (!File.Exists(filePicker.FileName)) throw new Exception("Fichier inexistant");


                    long finfo = new FileInfo(filePicker.FileName).Length;
                    if (finfo == 0) throw new Exception("Fichier vide");

                    String[] lines = File.ReadAllLines(filePicker.FileName);

                    for (int lineNumber = 0; lineNumber < lines.Length; lineNumber++)
                    {
                        String[] columns = lines[lineNumber].Split(' ');
                         throw new Exception("Une erreur L " + lineNumber + " !");
                    }

                    foreach (String line in lines)
                    {
                        String[] columns = line.Split(' ');
                        String humidity = Regex.Replace(columns[4], "%", "");
                        String temperature = columns[3];
                        String dataDate = columns[1] + " " + columns[2];


                        MySqlCommand command = connection.CreateCommand();
                        command.CommandText = "INSERT INTO data (sensor,humidity,temperature,import_date,data_date)VALUES(@sensor,@humidity,@temperature,@import_date,@data_date)";
                        

                        command.Parameters.AddWithValue("@humidity", humidity);
                        command.Parameters.AddWithValue("@data_date", dataDate);
                        command.Parameters.AddWithValue("@import_date", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        command.Parameters.AddWithValue("@sensor", sensor);
                        command.Parameters.AddWithValue("@temperature", temperature);
                        command.ExecuteNonQuery();
                        
                    }

                    connection.Close();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERREUR: " + ex.Message);
            }
        }
    }
}
