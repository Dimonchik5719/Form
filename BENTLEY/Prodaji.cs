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
    public partial class Prodaji : Form
    {
        public Prodaji()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuAdmin ma = new MenuAdmin();
            ma.Show();
            Hide();
        }

        private void Prodaji_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoDataSet.Klient". При необходимости она может быть перемещена или удалена.
            this.klientTableAdapter.Fill(this.avtoDataSet.Klient);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoDataSet.Avto". При необходимости она может быть перемещена или удалена.
            this.avtoTableAdapter.Fill(this.avtoDataSet.Avto);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoDataSet.Prodaji". При необходимости она может быть перемещена или удалена.
            this.prodajiTableAdapter.Fill(this.avtoDataSet.Prodaji);
            GetList();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        void GetList()
        {
            con = new SqlConnection(@"Data Source=LAPTOP-IUFK5CBJ\DIMON;Initial Catalog=Avto;User ID=sa;Password=123");
            da = new SqlDataAdapter("Select * from Prodaji", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Prodaji");
            dataGridView1.DataSource = ds.Tables["Prodaji"];
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
            cmd.CommandText = String.Format("insert into Prodaji(Nomer_prodaj,Nomer_avto,Nomer_klienta,Itogovaya_stoimost) values ('{0}','{1}','{2}','{3}')", textBox1.Text, comboBox1.Text, comboBox2.Text, textBox2.Text);
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
            {
                if (comboBox1.Text == "" || comboBox2.Text == "" || textBox1.Text == "" || textBox2.Text == "")
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
                        cmd.CommandText = string.Format("update Prodaji set Nomer_prodaj='{0}',Nomer_avto='{1}',Nomer_klienta'{2}', Itogovaya_stoimost'{3}' where Nomer_prodaj='{0}'", textBox1.Text, comboBox1.Text, comboBox2.Text, textBox2.Text);
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
            cmd.CommandText = String.Format("delete from Prodaji where Nomer_prodaj='{0}'", textBox1.Text);
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
