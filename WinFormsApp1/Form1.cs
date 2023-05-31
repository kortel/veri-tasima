using System.Data;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 f2 = new Form2();
        private void button1_Click(object sender, EventArgs e)
        {
            f2.askial(donustur(dataGridView1));
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
        
        
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            dt.Columns.Add("id");
            dt.Columns.Add("isim");
            dt.Columns.Add("miktar");
            dt.Rows.Add("1","ekmek","5");
            dt.Rows.Add("2","süt","25");
            dt.Rows.Add("3","yoðurt","13");
            dt.Rows.Add("4","su","3");
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridView1.DataSource = dt;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = f2.askidancagir();
        }
    }
}