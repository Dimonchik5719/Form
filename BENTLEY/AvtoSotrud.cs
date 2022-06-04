using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;

namespace BENTLEY
{
    public partial class AvtoSotrud : Form
    {
        public AvtoSotrud()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuSotrud ms = new MenuSotrud();
            ms.Show();
            Hide();
        }

        private void AvtoSotrud_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoDataSet.Avto". При необходимости она может быть перемещена или удалена.
            this.avtoTableAdapter.Fill(this.avtoDataSet.Avto);
            GetList();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        void GetList()
        {
            con = new SqlConnection(@"Data Source=LAPTOP-IUFK5CBJ\DIMON;Initial Catalog=Avto;User ID=sa;Password=123");
            da = new SqlDataAdapter("Select * from Avto", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Avto");
            dataGridView1.DataSource = ds.Tables["Avto"];
            dataGridView1.Columns[0].Visible = false;
            con.Close();
        }

        /// <summery>
        /// INSERT
        /// </summery>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = String.Format("insert into Avto(Nomer_Avto,Model, Cvet, Komplektacia) values ('{0}','{1}','{2}','{3}')", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        /// <summery>
        /// UPDATE
        /// </summery>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Не все поля заполнены!");
            }
            else
            {
                try
                {
                    cmd = new SqlCommand();
                    con.Open();
                    cmd.Connection = con;
                    cmd.CommandText = string.Format("update Avto set Nomer_Avto='{0}',Model='{1}', Cvet='{2}', Komplektacia='{3}' where Nomer_Avto='{0}'", textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    GetList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        /// <summery>
        /// DELETE
        /// </summery>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = String.Format("delete from Avto where Nomer_Avto='{0}'", textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            GetList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Excel.Application excel = new Excel.Application();
            excel.Visible = true;
            object Missing = Type.Missing;
            Workbook workbook = excel.Workbooks.Add(Missing);
            Worksheet sheet1 = (Worksheet)workbook.Sheets[1];
            int StartCol = 1;
            int StartRow = 1;
            for (int j = 0; j < dataGridView1.Columns.Count; j++)
            {
                Range myRange = (Range)sheet1.Cells[StartRow, StartCol + j];
                myRange.Value2 = dataGridView1.Columns[j].HeaderText;
            }
            StartRow++;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    Range myRange = (Range)sheet1.Cells[StartRow + i, StartCol + j];
                    myRange.Value2 = dataGridView1[j, i].Value == null ? "" : dataGridView1[j, i].Value;
                    myRange.Select();
                }
            }
        }
    }
}
