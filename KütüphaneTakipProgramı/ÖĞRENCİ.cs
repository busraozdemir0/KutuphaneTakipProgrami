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
    public partial class ÖĞRENCİ : Form
    {
        public ÖĞRENCİ()
        {
            InitializeComponent();
        }
        DataClasses1DataContext veri = new DataClasses1DataContext();
        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Eklemek istiyor musun?", "Yeni Kitap", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ÜYE ekle = new ÜYE();
                ekle.TCkimlikno = textBox1.Text;
                ekle.ÜyeNumarası = int.Parse(textBox2.Text);
                ekle.ÜyeAdı = textBox3.Text;
                ekle.ÜyeSoyadı = textBox4.Text;
                ekle.Cinsiyeti = comboBox1.Text;
                ekle.DoğumTarihi = DateTime.Parse(textBox5.Text);
                ekle.ÜyelikTarihi = DateTime.Parse(textBox6.Text);
                ekle.TelefonNo = textBox7.Text;
                veri.ÜYEs.InsertOnSubmit(ekle);
                veri.SubmitChanges();
                MessageBox.Show("Ekleme işleminiz tamamlandı.");
            }
            else
                MessageBox.Show("Ekleme işleminiz iptal edildi.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void ÖĞRENCİ_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var sorgu = from k in veri.ÜYEs select k;
            dataGridView1.DataSource = sorgu.ToList();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
