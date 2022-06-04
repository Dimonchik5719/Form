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
    public partial class MenuSotrud : Form
    {
        public MenuSotrud()
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
            KlientSotrud ks = new KlientSotrud();
            ks.Show();
            Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AvtoSotrud at = new AvtoSotrud();
            at.Show();
            Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ProdajiSotrud ps = new ProdajiSotrud();
            ps.Show();
            Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BuxgalterSotrud bs = new BuxgalterSotrud();
            bs.Show();
            Hide();
        }
    }
}
