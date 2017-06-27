using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApplication2.Classes;

namespace WindowsFormsApplication2
{
    public partial class SyntheseForm : Form
    {
        Form form;
        MainForm main;
        String sensorId;
        String sensorName;
        DateTime start;
        DateTime end;
        DateTime startSensorData;
        DateTime endSensorData;
        public SyntheseForm()
        {
            InitializeComponent();

        }
        public void refreshSynthese()
        {
            form = this.ParentForm;
            main = (MainForm)form;
            sensorId = main.getSensorId();
            sensorName = main.getSensorName();
            start = main.getStartDate();
            end = main.getEndDate();

            if (main.getSensorName() == "")
            {
                nameSensorLabel.Text = "Veuillez selectionner un capteur";
                uidSensorLabel.Text = "";
                initValue();
            }
            else
            {
                String sensorUID = null;
                //Selection des données et des capteurs liés
                String query = "SELECT s.label,s.uid,d.* from data d INNER JOIN sensor s ON s.id = d.sensor_id WHERE 1 ";
                //Ajout  filtre par capteur si un capteur est sélectionné
                if (sensorId != "") query += "AND sensor_id=@sensorId ";
                //Ajout date de début / date de fin
                query += " AND (data_date BETWEEN @start AND @end)";
                // Par ordre de date ascendante / capteur
                query += " ORDER BY d.data_date ASC,sensor_id";

                //Ajout des parametres échappés
                Dictionary<String, String> parameters = new Dictionary<string, string>();
                if (sensorId != "") parameters["@sensorId"] = sensorId;
                parameters["@start"] = start.ToString("yyyy-MM-dd HH:mm:ss");
                parameters["@end"] = end.ToString("yyyy-MM-dd HH:mm:ss");
                List<decimal> temp = new List<decimal>();
                List<decimal> humi = new List<decimal>();
                List<Dictionary<String, String>> data = Database.select(query, parameters);
                endSensorData = DateTime.Parse(data[0]["data_date"]);
                startSensorData = DateTime.Parse(data[0]["data_date"]);
                foreach (Dictionary<String, String> line in data)
                {
                    temp.Add(decimal.Parse(line["temperature"]));
                    humi.Add(decimal.Parse(line["humidity"]));
                    sensorUID = line["uid"];
                    graph.Series["TempSeries"].Points.Clear();
                    graph.Series["HumidSeries"].Points.Clear();
                    if (DateTime.Parse(line["data_date"]) < startSensorData) startSensorData = (DateTime.Parse(line["data_date"]));
                    if (DateTime.Parse(line["data_date"]) > endSensorData) endSensorData = DateTime.Parse(line["data_date"]);


                }
                nameSensorLabel.Text = sensorName;
                uidSensorLabel.Text = sensorUID;
                try
                {
                    tempMin.Text = Function.PlusPetiteValeur(temp).ToString(".") + " °";
                    tempMax.Text = Function.PlusGrandeValeur(temp).ToString(".") + " °";
                    tempMoy.Text = Function.valeurMoyenne(temp).ToString(".") + " °";
                    humiMin.Text = Function.PlusPetiteValeur(humi).ToString(".") + " %";
                    humiMax.Text = Function.PlusGrandeValeur(humi).ToString(".") + " %";
                    humiMoy.Text = Function.valeurMoyenne(humi).ToString(".") + " %";
                    foreach (Dictionary<String, String> line in data)
                    {
                        graph.Series["TempSeries"].Points.AddXY(line["data_date"], Convert.ToDecimal(line["temperature"]));
                        graph.Series["HumidSeries"].Points.AddY(Convert.ToDecimal(line["humidity"]));

                    }

                }
                catch
                {
                    MessageBox.Show("Il n'y a pas de donnée pour ce capteur", "ERREUR", MessageBoxButtons.OK);
                    initValue();
                }
            }
            startDate.Text = startSensorData.ToShortDateString();
            endDate.Text = endSensorData.ToShortDateString();
            TimeSpan Diff = endSensorData - startSensorData;
            term.Text = Diff.Hours.ToString() + " H ";
        }
        private void initValue()
        {
            tempMax.Text = "00 °";
            tempMin.Text = "00 °";
            tempMoy.Text = "00 °";
            humiMax.Text = "00 %";
            humiMin.Text = "00 %";
            humiMoy.Text = "00 %";
            foreach (var series in graph.Series)
            {
                series.Points.Clear();
            }
        }

        public MemoryStream getChart()
        {
            MemoryStream memoryStream = new MemoryStream();
            graph.SaveImage(memoryStream, ChartImageFormat.Png);
            return memoryStream;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
