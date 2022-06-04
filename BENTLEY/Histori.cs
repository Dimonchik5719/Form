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
    public partial class Histori : Form
    {
        public Histori()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuKlient mk = new MenuKlient();
            mk.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            var bm = new Bitmap(pictureBox2.Image);
            pictureBox1.Image = bm;
            //Название фото
            label4.Visible = true;
            label5.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            //Текст
            label12.Visible = true;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            var bm = new Bitmap(pictureBox3.Image);
            pictureBox1.Image = bm;
            //Название фото
            label5.Visible = true;
            label4.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            //Текст
            label26.Visible = true;
            label12.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            var bm = new Bitmap(pictureBox4.Image);
            pictureBox1.Image = bm;
            //Название фото
            label17.Visible = true;
            label5.Visible = false;
            label4.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            //Текст
            label27.Visible = true;
            label12.Visible = false;
            label26.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            var bm = new Bitmap(pictureBox5.Image);
            pictureBox1.Image = bm;
            //Название фото
            label18.Visible = true;
            label5.Visible = false;
            label4.Visible = false;
            label17.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            //Текст
            label28.Visible = true;
            label12.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            var bm = new Bitmap(pictureBox6.Image);
            pictureBox1.Image = bm;
            //Название фото
            label19.Visible = true;
            label5.Visible = false;
            label4.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label20.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            //Текст
            label29.Visible = true;
            label12.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            var bm = new Bitmap(pictureBox7.Image);
            pictureBox1.Image = bm;
            //Название фото
            label20.Visible = true;
            label5.Visible = false;
            label4.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            //Текст
            label30.Visible = true;
            label12.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            var bm = new Bitmap(pictureBox9.Image);
            pictureBox1.Image = bm;
            //Название фото
            label22.Visible = true;
            label5.Visible = false;
            label4.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            //Текст
            label31.Visible = true;
            label12.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            var bm = new Bitmap(pictureBox10.Image);
            pictureBox1.Image = bm;
            //Название фото
            label23.Visible = true;
            label5.Visible = false;
            label4.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label22.Visible = false;
            label24.Visible = false;
            label25.Visible = false;
            //Текст
            label32.Visible = true;
            label12.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            var bm = new Bitmap(pictureBox11.Image);
            pictureBox1.Image = bm;
            //Название фото
            label24.Visible = true;
            label5.Visible = false;
            label4.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label25.Visible = false;
            //Текст
            label33.Visible = true;
            label12.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label34.Visible = false;
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            var bm = new Bitmap(pictureBox12.Image);
            pictureBox1.Image = bm;
            //Название фото
            label25.Visible = true;
            label5.Visible = false;
            label4.Visible = false;
            label17.Visible = false;
            label18.Visible = false;
            label19.Visible = false;
            label20.Visible = false;
            label22.Visible = false;
            label23.Visible = false;
            label24.Visible = false;
            //Текст
            label34.Visible = true;
            label12.Visible = false;
            label26.Visible = false;
            label27.Visible = false;
            label28.Visible = false;
            label29.Visible = false;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
        }
    }
}
