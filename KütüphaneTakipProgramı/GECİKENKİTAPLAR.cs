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
    public partial class GECİKENKİTAPLAR : Form
    {
        public GECİKENKİTAPLAR()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            
               DataClasses1DataContext veri = new DataClasses1DataContext();
              

              var sorgu = from k in veri.EMANETDURUMs where k.Durum == "Teslim Edilmedi" &  (DateTime.Now.Date -Convert.ToDateTime( k.Veriştarihi.Value.Date)).TotalDays > 15 select k;
         
               dataGridView1.DataSource = sorgu.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
