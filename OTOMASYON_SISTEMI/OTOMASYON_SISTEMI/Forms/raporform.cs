using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTOMASYON_SISTEMI.Forms
{
    public partial class raporform : Form
    {
        public raporform()
        {
            InitializeComponent();
        }

        private void raporform_Load(object sender, EventArgs e)
        {
            //form açıldiginda ilgili tablolari getiriyoruz.
            Function.raporgetir("Gün_sonu1", rprtbl1);
            Function.raporgetir("Gün_sonu2", rprtbl2);
            Function.raporgetir("Gün_sonu3", rprtbl3);
            Function.raporgetir("Gün_sonu4", rprtbl4);
        }
        //Butonlara basildiginda gelecek tabloları yazıyoruz.

        //
        private void gunsonbtn_Click(object sender, EventArgs e)
        {
            Function.raporgetir("Gün_sonu1", rprtbl1);
            Function.raporgetir("Gün_sonu2", rprtbl2);
            Function.raporgetir("Gün_sonu3", rprtbl3);
            Function.raporgetir("Gün_sonu4", rprtbl4);
        }

        private void teslımbtn_Click(object sender, EventArgs e)
        {
            Function.raporgetir("Teslim_ozeti", rprtbl1);
        }

        private void odemebtn_Click(object sender, EventArgs e)
        {
            Function.raporgetir("Odeme_ozeti", rprtbl1);
        }

        private void iptalbtn_Click(object sender, EventArgs e)
        {
            Function.raporgetir("Iplat_ozeti", rprtbl1);
        }

        private void masabtn_Click(object sender, EventArgs e)
        {
            Function.raporgetir("Masa_ozeti", rprtbl1);
        }

        private void cesitbtn_Click(object sender, EventArgs e)
        {
            Function.raporgetir("Odeme_cesitleri", rprtbl1);
        }

        private void rezervebtn_Click(object sender, EventArgs e)
        {
            Function.raporgetir("Rezerve_rpr", rprtbl1);
        }

        private void calisanbtn_Click(object sender, EventArgs e)
        {
            Function.raporgetir("Calisan_rpr1", rprtbl1);
            Function.raporgetir("Calisan_rpr2", rprtbl2);
        }

        private void urunbtn_Click(object sender, EventArgs e)
        {
            Function.raporgetir("Ürün_rpr1", rprtbl1);
            Function.raporgetir("Ürün_rpr2", rprtbl2);
        }
        //Buraya kadar fonksiyon tanımlamalarını yapıyroruz.

        //
    }
}