using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KütüphaneTakipProgramı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            YENİ K = new YENİ();
            K.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ÖĞRENCİ K = new ÖĞRENCİ();
            K.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            EMANET K = new EMANET();
            K.Show();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            LİSTE K = new LİSTE();
            K.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            GİRİŞ K = new GİRİŞ();
            K.Show();
        }

        private void üyeListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÜYERAPOR K = new ÜYERAPOR();
            K.Show();
        }

        private void kitapListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KİTAPRAPOR K = new KİTAPRAPOR();
            K.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            GECİKENKİTAPLAR K = new GECİKENKİTAPLAR();
            K.Show();
        }

        private void kitabaGöreListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KİTAPADI K = new KİTAPADI();
            K.Show();
        }

        private void üyeAdınaGöreListeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ÜYEADI K = new ÜYEADI();
            K.Show();
        }

        private void barkodNoFiltreliToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BARKODNO K = new BARKODNO();
            K.Show();
        }

        private void cinsiyetiErkekOlanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CİNSİYET K = new CİNSİYET();
            K.Show();
        }

       

       
    }
}
