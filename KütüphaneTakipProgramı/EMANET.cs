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
    public partial class EMANET : Form
    {
        public EMANET()
        {
            InitializeComponent();
        }
        DataClasses1DataContext veri = new DataClasses1DataContext();
        int s1, s2,s3;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EMANETDURUM ekle = new EMANETDURUM();
            ekle.BarkodNo = int.Parse( dataGridView1.Rows[s1].Cells[0].Value.ToString());
            ekle.KitapAdı=dataGridView1.Rows[s1].Cells[1].Value.ToString();
            ekle.ÜyeNo = int.Parse(dataGridView2.Rows[s2].Cells[1].Value.ToString());
            ekle.ÜyeAdı = dataGridView2.Rows[s2].Cells[2].Value.ToString();
            ekle.Durum = "Teslim Edilmedi";
            ekle.Veriştarihi = DateTime.Now.Date;
            ekle.Alıştarihi = DateTime.Now.Date.AddDays(15);
            veri.EMANETDURUMs.InsertOnSubmit(ekle);
            veri.SubmitChanges();

            var sorgu = from k in veri.EMANETDURUMs where k.Durum == "Teslim Edilmedi" select k;
            dataGridView3.DataSource = sorgu.ToList();

            KİTAP yeni=(from k in veri.KİTAPs where k.BarkodNo==int.Parse( dataGridView1.Rows[s1].Cells[0].Value.ToString()) select k).SingleOrDefault();
            yeni.Durum = "Teslim Edilmedi";
            veri.SubmitChanges();
            var sorgu1 = from k in veri.KİTAPs where k.Durum == "Teslim Edildi" select k;
            dataGridView1.DataSource = sorgu1.ToList();
        }

        private void EMANET_Load(object sender, EventArgs e)
        {
           var sorgu = from k in veri.KİTAPs where k.Durum=="Teslim Edildi" select k;
            dataGridView1.DataSource = sorgu.ToList();

            var sorgu2 = from k in veri.ÜYEs select k;
            dataGridView2.DataSource = sorgu2.ToList();

            var sorgu3 = from k in veri.EMANETDURUMs where k.Durum == "Teslim Edilmedi" select k;
            dataGridView3.DataSource = sorgu3.ToList();
        }
        
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            s1 = e.RowIndex;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            s2 = e.RowIndex;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            KİTAP yeni = (from k in veri.KİTAPs where k.BarkodNo == int.Parse(dataGridView3.Rows[s3].Cells[3].Value.ToString()) select k).SingleOrDefault();
            yeni.Durum = "Teslim Edildi";
            veri.SubmitChanges();

            var sorgu1 = from k in veri.KİTAPs where k.Durum == "Teslim Edildi" select k;
            dataGridView1.DataSource = sorgu1.ToList();


            EMANETDURUM yeni1 = (from k in veri.EMANETDURUMs where k.BarkodNo == int.Parse(dataGridView3.Rows[s3].Cells[3].Value.ToString()) select k).SingleOrDefault();
            yeni1.Durum = "Teslim Edildi";
            veri.SubmitChanges();  
         
            var sorgu = from k in veri.EMANETDURUMs where k.Durum == "Teslim Edilmedi"  select k;
            dataGridView3.DataSource = sorgu.ToList();
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            s3 = e.RowIndex;
        }
    }
}
