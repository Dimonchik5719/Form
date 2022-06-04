using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BENTLEY
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                if (textBox2.Text == "12345")
                {
                    MenuAdmin ma = new MenuAdmin();
                    ma.Show();
                    Hide();
                }
            }
            else
                MessageBox.Show("Логин или пароль не верный");
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "sotrudnik")
            {
                if (textBox2.Text == "54321")
                {
                    MenuSotrud ms = new MenuSotrud();
                    ms.Show();
                    Hide();
                }
            }
            else
                MessageBox.Show("Логин или пароль не верный");
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MenuKlient mk = new MenuKlient();
            mk.Show();
            Hide();
        }

        bool vis = true;
        private void button1_Click(object sender, EventArgs e)
        {
            if (vis)
            {
                textBox2.UseSystemPasswordChar = false;
                vis = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                vis = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }
    }
}
