
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using WindowsFormsApplication2.Classes;

namespace WindowsFormsApplication2
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            
            InitializeComponent();
            selectLoadDataGrid();
        }

        void selectLoadDataGrid()
        {
            MySqlConnection connection = Database.startConnect();
            
           
                String query = "SELECT sensor.label as Capteur, data.humidity as Humidite, data.temperature as Temperature, data.data_date as Date FROM data, sensor where data.sensor_id= sensor.id";
                LoadDataGrid(connection, query);
            
        }

        private void LoadDataGrid(MySqlConnection connection, String query)
        {
            DataTable table = new DataTable();
            MySqlDataAdapter myAdapter = new MySqlDataAdapter(query, connection);
            myAdapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
