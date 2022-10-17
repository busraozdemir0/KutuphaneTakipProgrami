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
    public partial class YENİ : Form
    {
        public YENİ()
        {
            InitializeComponent();
        }
        DataClasses1DataContext veri = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var sorgu = from k in veri.KİTAPs select k;
            dataGridView1.DataSource = sorgu.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eklemek istiyor musun?", "Yeni Kitap", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                KİTAP ekle = new KİTAP();
                ekle.BarkodNo = int.Parse(textBox1.Text);
                ekle.KitapAdı = textBox2.Text;
                ekle.Yazarı = textBox3.Text;
                ekle.YayınEvi = textBox4.Text;
                ekle.SayfaSayısı = int.Parse(textBox5.Text);
                ekle.StokSayısı = int.Parse(textBox6.Text);
                ekle.BasımYılı = DateTime.Parse(textBox7.Text);
                veri.KİTAPs.InsertOnSubmit(ekle);
                veri.SubmitChanges();
                MessageBox.Show("Ekleme işleminiz tamamlandı.");
            }
            else
            {
                MessageBox.Show("Ekleme işleminiz iptal edildi.");
            }
        }
    }
}
