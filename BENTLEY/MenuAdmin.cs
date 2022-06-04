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
    public partial class MenuAdmin : Form
    {
        public MenuAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authorization au = new Authorization();
            au.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sotrudnik so = new Sotrudnik();
            so.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Klient kl = new Klient();
            kl.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Avto av = new Avto();
            av.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Buxgalteria bu = new Buxgalteria();
            bu.Show();
            Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Prodaji pr = new Prodaji();
            pr.Show();
            Hide();
        }
    }
}
