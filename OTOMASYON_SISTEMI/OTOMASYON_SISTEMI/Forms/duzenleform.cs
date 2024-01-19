using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using OTOMASYON_SISTEMI;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OTOMASYON_SISTEMI.Forms
{
    public partial class duzenleform : Form
    {
        SqlConnection con;
        SqlDataReader rdr;
        SqlCommand cmd;
        baglan join = new baglan();
        public duzenleform()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(join.constring);
            cmd = new SqlCommand();
        }
        //isim değişkenlerimizi tanımlıyoruz.
        public static string masaisim;
        public static string masakpst;
        public static string calisanisim;
        public static string calisansoyisim;
        public static string calisanunvan;
        public static string calisantelno;
        public static string urunisim;
        public static string urunkpst;
        public static string urunucret;

        private void duzenleform_Load(object sender, EventArgs e)
        {
            //form load olduğunda ilgili tabloları getiriyor.
            Function.tablogetir("masa", masatbl);
            Function.tablogetir("calisan", calisantbl);
            Function.tablogetir("urun", uruntbl);
            //form load olduğunda tbox textlerini public içine alıyoruz.
            masaisim = misimtbox.Text;
            masakpst = mkpstbox.Text;
            calisanisim = cisimtbox.Text;
            calisansoyisim = csoyadtbox.Text;
            calisanunvan = cunvantbox.Text;
            calisantelno = cteltbox.Text;
            urunisim = uisimtbox.Text;
            urunkpst = uktgrtbox.Text;
            urunucret = ucretbox.Text;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void MASA_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void CALISAN_Click(object sender, EventArgs e)
        {

        }

        private void meklebtn_Click(object sender, EventArgs e)
        {
            //veri ekleme, gösterme ve tbox içini temizliyoruz.
            Function.veriekle("masa");
            Function.tablogetir("masa", masatbl);
            misimtbox.Clear();
            mkpstbox.Clear();
        }

        private void ceklebtn_Click(object sender, EventArgs e)
        {
            //veri ekleme, gösterme ve tbox içini temizliyoruz.
            Function.veriekle("calisan");
            Function.tablogetir("calisan", calisantbl);
            cisimtbox.Clear();
            csoyadtbox.Clear();
            cunvantbox.Clear();
            cteltbox.Clear();
        }

        private void ueklebtn_Click(object sender, EventArgs e)
        {
            //veri ekleme, gösterme ve tbox içini temizliyoruz.
            Function.veriekle("urun");
            Function.tablogetir("urun", uruntbl);
            uisimtbox.Clear();
            uktgrtbox.Clear();
            ucretbox.Clear();
            unotbox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //tablonun seçili satırına göre silme işlemini gerçekleştiriyoruz.
            foreach (DataGridViewRow drow in masatbl.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                Function.verisil("masa", id);
                Function.tablogetir("masa", masatbl);
            }
            misimtbox.Clear();
            mkpstbox.Clear();
        }

        private void csilbtn_Click(object sender, EventArgs e)
        {
            //tablonun seçili satırına göre silme işlemini gerçekleştiriyoruz.
            foreach (DataGridViewRow drow in calisantbl.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                Function.verisil("calisan", id);
                Function.tablogetir("calisan", calisantbl);
            }
            cisimtbox.Clear();
            csoyadtbox.Clear();
            cunvantbox.Clear();
            cteltbox.Clear();
        }

        private void usilbtn_Click(object sender, EventArgs e)
        {
            //tablonun seçili satırına göre silme işlemini gerçekleştiriyoruz.
            foreach (DataGridViewRow drow in uruntbl.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                Function.verisil("urun", id);
                Function.tablogetir("urun", uruntbl);
            }
            uisimtbox.Clear();
            uktgrtbox.Clear();
            ucretbox.Clear();
            unotbox.Clear();
        }

        private void masatbl_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //tabloya tıklandığında verilerin tbox içine getirilmesi olayını ayarlıyoruz.
            int i = e.RowIndex;
            misimtbox.Text = masatbl.Rows[i].Cells[1].Value.ToString();
            mkpstbox.Text = masatbl.Rows[i].Cells[2].Value.ToString();
        }

        private void calisantbl_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //tabloya tıklandığında verilerin tbox içine getirilmesi olayını ayarlıyoruz.
            int i = e.RowIndex;
            cisimtbox.Text = calisantbl.Rows[i].Cells[1].Value.ToString();
            csoyadtbox.Text = calisantbl.Rows[i].Cells[2].Value.ToString();
            cunvantbox.Text = calisantbl.Rows[i].Cells[3].Value.ToString();
            cteltbox.Text = calisantbl.Rows[i].Cells[4].Value.ToString();
        }

        private void uruntbl_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //tabloya tıklandığında verilerin tbox içine getirilmesi olayını ayarlıyoruz.
            int i = e.RowIndex;
            uisimtbox.Text = uruntbl.Rows[i].Cells[1].Value.ToString();
            uktgrtbox.Text = uruntbl.Rows[i].Cells[2].Value.ToString();
            ucretbox.Text = uruntbl.Rows[i].Cells[3].Value.ToString();
            unotbox.Text = uruntbl.Rows[i].Cells[4].Value.ToString();
        }

        private void mgunceltbox_Click(object sender, EventArgs e)
        {
            //veri güncelleme için seçili satırın bilgisini aldıktan sonra
            //ilgili tbox ların textlerine eşitleyerek gümcelliyoruz.
            foreach (DataGridViewRow drow in masatbl.SelectedRows)
            {
                con.Open();
                string guncelle = ("Update Masa_Bilgi Set masa_ismi = @masaismi, kapasite = @kpst Where id = @id");
                SqlCommand cmd = new SqlCommand(guncelle, con);
                cmd.Parameters.AddWithValue("@masaismi", misimtbox.Text);
                cmd.Parameters.AddWithValue("@kpst", mkpstbox.Text);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(drow.Cells[0].Value));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                Function.tablogetir("masa", masatbl);
            }
            misimtbox.Clear();
            mkpstbox.Clear();
        }

        private void cgunceltbox_Click(object sender, EventArgs e)
        {
            //veri güncelleme için seçili satırın bilgisini aldıktan sonra
            //ilgili tbox ların textlerine eşitleyerek gümcelliyoruz.
            foreach (DataGridViewRow drow in calisantbl.SelectedRows)
            {
                con.Open();
                string guncelle = ("Update Calisan_Bilgi Set calisan_ismi = @calisanismi," +
                "calisan_soyismi = @calisansoyismi, calisan_unvani = @calisanunvani," +
                "telefon_no = @telefonno Where id = @id");
                SqlCommand cmd = new SqlCommand(guncelle, con);
                cmd.Parameters.AddWithValue("@calisanismi", cisimtbox.Text);
                cmd.Parameters.AddWithValue("@calisansoyismi", csoyadtbox.Text);
                cmd.Parameters.AddWithValue("@calisanunvani", cunvantbox.Text);
                cmd.Parameters.AddWithValue("@telefonno", cteltbox.Text);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(drow.Cells[0].Value));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                Function.tablogetir("calisan", calisantbl);
            }
            cisimtbox.Clear();
            csoyadtbox.Clear();
            cunvantbox.Clear();
            cteltbox.Clear();
        }

        private void ugunceltbox_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(join.constring);
            //veri güncelleme için seçili satırın bilgisini aldıktan sonra
            //ilgili tbox ların textlerine eşitleyerek güncelliyoruz.
            foreach (DataGridViewRow drow in uruntbl.SelectedRows)
            {
                con.Open();
                string guncelle = ("Update Urun_Bilgi Set urun_ismi = @urunismi,"+
                "urun_kategorisi = @urunktgr, urun_ucreti = @urunucreti, urun_no = @urunno Where id = @id");
                string gonder = ("INSERT INTO Stok_Bilgi (urun_id, miktar, birim) VALUES (@urunid,'0','litre')");
                SqlCommand cmd = new SqlCommand(guncelle, con);
                SqlCommand cmd0 = new SqlCommand(gonder, con);
                cmd.Parameters.AddWithValue("@urunismi", uisimtbox.Text);
                cmd.Parameters.AddWithValue("@urunktgr", uktgrtbox.Text);
                cmd.Parameters.AddWithValue("@urunucreti", ucretbox.Text);
                cmd.Parameters.AddWithValue("@urunno", unotbox.Text);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(drow.Cells[0].Value));
                cmd0.Parameters.AddWithValue("@urunid", Convert.ToInt32(drow.Cells[0].Value));
                cmd.ExecuteNonQuery();
                cmd0.ExecuteNonQuery();
                MessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                Function.tablogetir("urun", uruntbl);
            }
            uisimtbox.Clear();
            uktgrtbox.Clear();
            ucretbox.Clear();
            unotbox.Clear();
        }
    }
}