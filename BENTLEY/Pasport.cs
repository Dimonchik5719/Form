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
    public partial class Pasport : Form
    {
        public Pasport()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sotrudnik so = new Sotrudnik();
            so.Show();
            Hide();
        }

        private void Pasport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoDataSet.Sotrudnic". При необходимости она может быть перемещена или удалена.
            this.sotrudnicTableAdapter.Fill(this.avtoDataSet.Sotrudnic);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "avtoDataSet.Pasportnie_dannie". При необходимости она может быть перемещена или удалена.
            this.pasportnie_dannieTableAdapter.Fill(this.avtoDataSet.Pasportnie_dannie);
            GetList();
        }
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;

        void GetList()
        {
            con = new SqlConnection(@"Data Source=LAPTOP-IUFK5CBJ\DIMON;Initial Catalog=Avto;User ID=sa;Password=123");
            da = new SqlDataAdapter("Select * from Pasportnie_dannie", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Pasportnie_dannie");
            dataGridView1.DataSource = ds.Tables["Pasportnie_dannie"];
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
            cmd.CommandText = String.Format("insert into Pasportnie_dannie(Nomer_sotrudnica,Seria, Nomer, Mesto_vidachi, Data_vidachi, Kod_podrazdelenia, Pol, Data_rogdenia) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", comboBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, comboBox3.Text, comboBox2.Text);
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
            if (comboBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || comboBox3.Text == "" || comboBox2.Text == "")
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
                    cmd.CommandText = string.Format("update Pasportnie_dannie set Nomer_sotrudnica='{0}',Seria='{1}',Nomer='{2}', Mesto_vidachi='{3}',Data_vidachi='{4}', Kod_podrazdelenia='{5}', Pol='{6}',Data_rogdenia='{7}' where Nomer_sotrudnica='{0}' ", comboBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, comboBox3.Text, comboBox2.Text);
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
            cmd.CommandText = String.Format("delete from Pasportnie_dannie where Nomer_sotrudnica='{0}'", comboBox1.Text);
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
