using OTOMASYON_SISTEMI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Sınıfın namespace ini yazıyoruz böylelikle kütüphaneyi eklemiş oluyoruz.
using OTOMASYON_SISTEMI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.Sql;
using System.Data.SqlClient;


namespace OTOMASYON_SISTEMI
{
    public partial class anaform : Form
    {
        SqlConnection con;
        SqlDataReader rdr;
        SqlCommand cmd;
        public anaform()
        {
            InitializeComponent();
        }
        private void formgetir(Form frm)
        {
            //panelin içindekileri temizler.
            anapnl.Controls.Clear();
            //MDI=Multiple Document Interface (Çoklu Belge Arayüzü)
            frm.MdiParent = this;
            //formun kenarlıklarını kaldırır ve none özelliği verir.
            frm.FormBorderStyle = FormBorderStyle.None;
            //formun bulunduğu yeri kaplaması için kullanılır.
            frm.Dock = DockStyle.Fill;
            //panel içine formu ekleme.
            anapnl.Controls.Add(frm);
            //formu ekrana gösterme.
            frm.Show();
        }
        //Form tanımlamaları
        menuform menu = new menuform();
        duzenleform edit = new duzenleform();
        masaform table = new masaform();
        siparisform order = new siparisform();
        raporform report = new raporform();
        stokform stock = new stokform();
        kasaform chest = new kasaform();
        ayarlarform settings = new ayarlarform();

        private void anaform_FormClosing(object sender, FormClosingEventArgs e)
        {
            //uygulamayı sonlandırıyor.
            Application.Exit();
        }

        private void anaform_Load(object sender, EventArgs e)
        {
            //anlık saat ve tarih bilgisi
            timer1.Start();
            formgetir(menu);
        }

        private void ustpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //alt menüdeki butonlara tıklandığında form getirme olaylarını yazıyoruz.
        private void anastok_Click(object sender, EventArgs e)
        {
            formgetir(stock);
        }

        private void anakasa_Click(object sender, EventArgs e)
        {
            formgetir(chest);
        }

        private void anaduzenle_Click(object sender, EventArgs e)
        {
            formgetir(edit);
        }

        private void anasatis_Click(object sender, EventArgs e)
        {
            formgetir(table);  
        }

        private void anasiparis_Click(object sender, EventArgs e)
        {
            formgetir(order);
        }

        private void anarapor_Click(object sender, EventArgs e)
        {
            formgetir(report);
        }

        private void anaayarlar_Click(object sender, EventArgs e)
        {
            formgetir(settings);
        }

        private void anamenu_Click(object sender, EventArgs e)
        {
            formgetir(menu);
        }
        //buraya kadar fonksiyon ile form getirme olayını yazıyoruz.
        private void timer1_Tick(object sender, EventArgs e)
        {
            //anlık saat
            anasaat.Text = DateTime.Now.ToLongTimeString();
            //anlık tarih
            anatarih.Text = DateTime.Now.ToLongDateString();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
