using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inter_ctive_tv_remote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Power();
        }

        private void radButton2_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.K1();
        }

        private void radButton3_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.K2();
        }

        private void radButton4_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.K3();
        }

        private void radButton5_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.K4();
        }

        private void radButton6_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.K5();
        }

        private void radButton7_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.K6();
        }

        private void radButton8_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.K7();
        }

        private void radButton9_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.K8();
        }

        private void radButton10_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.K9();
        }

        private void radButton12_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.K0();
        }

        private void radButton11_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Fav();
        }

        private void radButton13_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Txt();
        }

        private void radButton14_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Exit();
        }

        private void radButton17_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Menu();
        }

        private void radButton19_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Back();
        }

        private void radButton18_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Yukari();
        }

        private void radButton24_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Asagi();
        }

        private void radButton20_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Sol();
        }

        private void radButton22_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Sag();
        }

        private void radButton21_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Orta();
        }

        private void radButton23_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Tools();
        }

        private void radButton26_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Varti();
        }

        private void radButton27_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Veksi();
        }

        private void radButton30_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Mute();
        }

        private void radButton28_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Parti();
        }

        private void radButton29_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Peksi();
        }

        private void radButton15_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.SoruIsaret();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Kirmizi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Yesil();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Sari();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Mavi();
        }

        private void radButton32_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.OncekiVid();
        }
        private void radButton33_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.SonrakiVid();
        }

        private void radButton34_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.GeriSar();
        }

        private void radButton35_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.IleriSar();
        }

        private void radButton38_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Oynat();
        }

        private void radButton37_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Duraklat();
        }

        private void radButton16_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Internet();
        }

        private void radButton25_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Guide();
        }

        private void radButton31_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Source();
        }

        private void radButton39_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Kaydet();
        }

        private void radButton36_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Durdur();
        }

        private void radButton42_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Sub();
        }

        private void radButton41_Click(object sender, EventArgs e)
        {
            InteractiveAPI.tvip = textBox1.Text;
            InteractiveAPI.Dub();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
    }
}
