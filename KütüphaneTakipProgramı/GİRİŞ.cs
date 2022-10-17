using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KütüphaneTakipProgramı
{
    public partial class GİRİŞ : Form
    {
        public GİRİŞ()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            //string kaynak = "Data Source=.\\SQLEXPRESS;Initial Catalog=Kütüphane;Integrated Security=True;Pooling=False";
            //string kaynak = "Data Source=DESKTOP-G8IS3SP\\SQLEXPRESS;Initial Catalog=Kütüphane;Integrated Security=True";

            string kaynak = "Data Source=DESKTOP-G8IS3SP\\SQLEXPRESS;Initial Catalog=KutuphaneOtomasyon;Integrated Security=True; Pooling=False";

            DataClasses1DataContext veri = new DataClasses1DataContext(kaynak);

            int sorgu = (from k in veri.KULLANICIs where k.adı == textBox1.Text & k.şifre == textBox2.Text select k).Count();
            if (sorgu != 0)
            {

                Form1 frm = new Form1();
                frm.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Kullanıcı adını veya şifrenizi yanlış girdiniz." + "\n" + "Tekrar Deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
