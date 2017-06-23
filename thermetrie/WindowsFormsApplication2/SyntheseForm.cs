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
    public partial class SyntheseForm : Form
    {
        public SyntheseForm()
        {
            InitializeComponent();
            
        }
        public void refreshSynthese()
        {
            Form form = this.ParentForm;
            MainForm main = (MainForm)form;
            String sensorId = main.getSensorId();
            String sensorName = main.getSensorName();
            DateTime start = main.getStartDate();
            DateTime end = main.getEndDate();

            if (main.getSensorName() == "")
            {
                nameSensorLabel.Text = "Veuillez selectionner un capteur";
                uidSensorLabel.Text = "";
            }
            else
            {
                nameSensorLabel.Text = sensorName;
                uidSensorLabel.Text = sensorId;
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

                List<decimal> temp = new List<decimal>();
                foreach (Dictionary<String, String> line in Database.select(query, parameters))
                {
                    temp.Add(decimal.Parse(line["temperature"]));
                }
                tempMin.Text = Function.PlusPetiteValeur(temp).ToString(".##");
                tempMax.Text = Function.PlusGrandeValeur(temp).ToString(".##");
                tempMoy.Text = Function.valeurMoyenne(temp).ToString(".##");

            }
            startDate.Text = start.ToShortDateString();
            endDate.Text = end.ToShortDateString();
            TimeSpan Diff = end - start;
            decimal timeDiff = (decimal)Diff.TotalHours;
            term.Text = timeDiff.ToString(".##") + " H";



            


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
