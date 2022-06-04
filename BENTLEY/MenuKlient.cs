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
    public partial class MenuKlient : Form
    {
        public MenuKlient()
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
            Avtotovar at = new Avtotovar();
            at.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Histori hi = new Histori();
            hi.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KartaDiller kd = new KartaDiller();
            kd.Show();
            Hide();
        }
    }
}
