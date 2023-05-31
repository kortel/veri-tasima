using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void askial(DataTable dt)
        {
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = dt;
        }
        public DataTable askidancagir()
        {
            return donustur(dataGridView1);
        }
        DataTable donustur(DataGridView data)
        {
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn column in data.Columns)
            {
                dt.Columns.Add(column.HeaderText, column.ValueType);
            }
            foreach (DataGridViewRow row in data.Rows)
            {
                dt.Rows.Add();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                }
            }
            return dt;
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
