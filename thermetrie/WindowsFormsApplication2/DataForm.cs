using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();


            DataGridViewRow row = new DataGridViewRow();



            /*
            DataGridViewRow row = new DataGridViewRow();
            int id = 1;
            row.Tag = id;
            row.CreateCells(dataTable, new object[]{
                    columns[1],
                    columns[2],
                    columns[3],
                    Properties.Resources.thermometer
                });
            dataTable.Rows.Add(row);
            */
        }
    }
}
