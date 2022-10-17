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
    public partial class LİSTE : Form
    {
        public LİSTE()
        {
            InitializeComponent();
        }
        DataClasses1DataContext veri = new DataClasses1DataContext();
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            var sorgu = from k in veri.KİTAPs orderby k.BarkodNo ascending select k;
            dataGridView1.DataSource = sorgu.ToList();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            var sorgu=from k in veri.KİTAPs orderby k.KitapAdı descending select k;
            dataGridView1.DataSource = sorgu.ToList();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            var sorgu = from k in veri.KİTAPs orderby k.BasımYılı descending select k;
            dataGridView1.DataSource = sorgu.ToList();
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            var sorgu = from k in veri.KİTAPs orderby k.YayınEvi ascending select k;
            dataGridView1.DataSource = sorgu.ToList();
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            var sorgu = from k in veri.ÜYEs orderby k.ÜyeNumarası descending select k;
            dataGridView2.DataSource = sorgu.ToList();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            var sorgu = from k in veri.ÜYEs orderby k.ÜyeAdı ascending select k;
            dataGridView2.DataSource = sorgu.ToList();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            var sorgu = from k in veri.ÜYEs orderby k.DoğumTarihi descending select k;
            dataGridView2.DataSource = sorgu.ToList();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            var sorgu = from k in veri.ÜYEs orderby k.ÜyelikTarihi ascending select k;
            dataGridView2.DataSource = sorgu.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
