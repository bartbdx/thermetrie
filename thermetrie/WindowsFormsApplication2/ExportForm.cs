using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text;
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
                if (!cbExcel.Checked && !cbPDF.Checked) throw new Exception("Choisir un format d'export");
                MainForm main = (MainForm)this.ParentForm;
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.DefaultExt = cbPDF.Checked ? "pdf" : "csv";
                String name = main.getSensorName();
                name = Function.slugify(name + DateTime.Now);
                if (main.getSensorName() == "") name = "allSensor";
                saveFile.FileName = name;
         

                if (cbExcel.Checked)
                {

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
                else if (cbPDF.Checked)
                {
                    if (saveFile.ShowDialog() == DialogResult.OK)
                    {
                        String sensorName = main.getSensorName();
                        String stream = "";
                        String sensorId = main.getSensorId();
                        DateTime start = main.getStartDate();
                        DateTime end = main.getEndDate();
                        String sensorUID = null;
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
                        List<decimal> humi = new List<decimal>();
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
                            temp.Add(decimal.Parse(row["temperature"]));
                            humi.Add(decimal.Parse(row["humidity"]));
                            sensorUID = row["uid"];

                        }
                        String tempMin = Function.PlusPetiteValeur(temp).ToString(".") + " °";
                        String tempMax = Function.PlusGrandeValeur(temp).ToString(".") + " °";
                        String tempMoy = Function.valeurMoyenne(temp).ToString(".") + " °";
                        String humiMin = Function.PlusPetiteValeur(humi).ToString(".") + " %";
                        String humiMax = Function.PlusGrandeValeur(humi).ToString(".") + " %";
                        String humiMoy = Function.valeurMoyenne(humi).ToString(".") + " %";
                        TimeSpan Diff = end - start;
                        

                        FileStream fs = new FileStream(saveFile.FileName, FileMode.Create, FileAccess.Write, FileShare.None);
                        Document doc = new Document(PageSize.A4, 30, 30, 30, 30);
                        doc.AddTitle("Rapport de relevés");

                        doc.AddKeywords("Metadata, iTextSharp 5.5.11");
                        doc.AddCreator("iTextSharp 5.5.11");
                        doc.AddAuthor("Thermetrie");
                        doc.AddHeader("Nothing", "No Header");
                        Rectangle rec2 = new Rectangle(PageSize.A4);
                        PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                        doc.Open();
                        doc.Add(new Paragraph("Rapport Temperature et Humidité"));
                        doc.Add(new Paragraph(" "));
                        doc.Add(new Paragraph("Date de rapport : " + DateTime.Now));
                        List infos = new List();
                        infos.IndentationLeft = 20f;
                        infos.Add("Date de debut : " + start);
                        infos.Add("Date de fin : " + end);
                        infos.Add("Nom de capteur : " + sensorName);
                        infos.Add("Uid capteur : " + sensorUID);
                        infos.Add("T° min : " + tempMin + " -- T° max : "+ tempMax + " -- T° moyenne :" + tempMoy);
                        infos.Add("Hum. min : " + humiMin + "  -- hum. max : " + humiMax + " -- hum.moyenne : " + humiMoy);
                        infos.Add("Periode ( en jours) : " + Diff.Days);
                        infos.Add("Periode ( en heures) : " + Diff.TotalHours);
                        doc.Add(infos);

                        Image img = Image.GetInstance(main.synthesis.getChart().GetBuffer());
                        img.ScalePercent(75f);
                        doc.Add(img);
                        doc.NewPage();
                        PdfPTable table = new PdfPTable(8);
                        table.WidthPercentage = 100;

                        //Nom des colonnes sur la premiere ligne
                        foreach (KeyValuePair<String, String> cell in results[0])
                        {
                            table.AddCell(new Phrase(cell.Key));
                            table.HeaderRows = 1;
                        }
                        foreach (Dictionary<String, String> row in results)
                        {
                            //Toutes les valeurs des cellules de la ligne courante
                            foreach (KeyValuePair<String, String> cell in row)
                            {
                               table.AddCell(new Phrase(cell.Value));
                            }
                        }
                        doc.Add(table);
                        doc.Close();
                        writer.Close();
                        String subject = "Rapport relevé de temperatures et humidité";
                        String content = " Bosses faineant !!!!";
                        
                        fs.Close();
                        if (chkMailFile.Checked) Function.send_report(subject, content, name);
                        MessageBox.Show("Export effectué avec succès sur " + saveFile.FileName);
                        if (chkOpenFile.Checked) Process.Start(saveFile.FileName);
                    }
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
