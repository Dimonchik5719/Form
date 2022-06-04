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
    public partial class KartaDiller : Form
    {
        public KartaDiller()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuKlient mk = new MenuKlient();
            mk.Show();
            Hide();
        }
    }
}
