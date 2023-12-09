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

namespace OTOMASYON_SISTEMI
{
    public partial class anaform : Form
    {
        public anaform()
        {
            InitializeComponent();
        }

        private void formgetir(Form frm)
        {
            //panelin içindekileri temizler.
            panel1.Controls.Clear();
            //MDI=Multiple Document Interface (Çoklu Belge Arayüzü)
            frm.MdiParent = this;
            //formun kenarlıklarını kaldırır ve none özelliği verir.
            frm.FormBorderStyle = FormBorderStyle.None;
            //formun bulunduğu yeri kaplaması için kullanılır.
            frm.Dock = DockStyle.Fill;
            //panel içine formu ekleme.
            panel1.Controls.Add(frm);
            //formu ekrana gösterme.
            frm.Show();
        }
        private void anaform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void anaform_Load(object sender, EventArgs e)
        {
            //anlık saat ve tarih bilgisi
            timer1.Start();
            menuform menü = new menuform();
            formgetir(menü);
        }

        private void ustpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void anastok_Click(object sender, EventArgs e)
        {
            stokform stock = new stokform();
            formgetir(stock);
        }

        private void anakasa_Click(object sender, EventArgs e)
        {
            kasaform chest = new kasaform();
            formgetir(chest);
        }

        private void anaduzenle_Click(object sender, EventArgs e)
        {
            duzenleform edit = new duzenleform();
            formgetir(edit);
        }

        private void anasatis_Click(object sender, EventArgs e)
        {
            satisform sales = new satisform();
            formgetir(sales);
        }

        private void anasiparis_Click(object sender, EventArgs e)
        {
            siparisform order = new siparisform();
            formgetir(order);
        }

        private void anarapor_Click(object sender, EventArgs e)
        {
            raporform report = new raporform();
            formgetir(report);
        }

        private void anaayarlar_Click(object sender, EventArgs e)
        {
            ayarlarform settings = new ayarlarform();
            formgetir(settings);
        }

        private void anamenu_Click(object sender, EventArgs e)
        {
            menuform menü = new menuform();
            formgetir(menü);
        }

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
