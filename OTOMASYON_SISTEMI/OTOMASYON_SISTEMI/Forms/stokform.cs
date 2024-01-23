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
    public partial class stokform : Form
    {
        public stokform()
        {
            InitializeComponent();
        }

        private void btnanaymk_Click(object sender, EventArgs e)
        {
            //Kategoriye göre veri getirme işlemlerini fonksiyon ile çağırıyoruz.
            Function.stokktgrgetir(lviewstok, btnanaymk);
        }

        private void stokform_Load(object sender, EventArgs e)
        {
            //urunun stok bilgilerini getiriyoruz.
            lviewstok.Items.Clear();
            baglan join = new baglan();
            SqlConnection con = new SqlConnection(join.constring);
            SqlCommand cmd = new SqlCommand("Select Stok_Bilgi.id, urun_ismi, Stok_Bilgi.miktar, " +
            "Stok_Bilgi.birim, urun_ucreti From posdb.dbo.Urun_Bilgi Join posdb.dbo.Stok_Bilgi " +
            "on Urun_Bilgi.id = Stok_Bilgi.urun_id", con);
            SqlDataReader rdr = null;
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                rdr = cmd.ExecuteReader();
                int sayac = 0;
                while (rdr.Read())
                {
                    lviewstok.Items.Add(rdr["urun_ismi"].ToString());
                    lviewstok.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(rdr["miktar"])));
                    lviewstok.Items[sayac].SubItems.Add(Convert.ToString(rdr["birim"]));
                    lviewstok.Items[sayac].SubItems.Add(Convert.ToString(rdr["urun_ucreti"]));
                    sayac++;
                }
            }
            catch (Exception ex)
            {
                string hata = ex.Message;
                throw;
            }
            finally
            {
                rdr.Close();
                con.Dispose();
                con.Close();
            }
        }
        //Kategoriye göre veri getirme işlemlerini fonksiyon ile çağırıyoruz.

        //
        private void btniçecek_Click(object sender, EventArgs e)
        {
            Function.stokktgrgetir(lviewstok, btniçecek);
        }

        private void btntatlı_Click(object sender, EventArgs e)
        {
            Function.stokktgrgetir(lviewstok, btntatlı);
        }

        private void btnyanurun_Click(object sender, EventArgs e)
        {
            Function.stokktgrgetir(lviewstok, btnyanurun);
        }

        private void btnfastfood_Click(object sender, EventArgs e)
        {
            Function.stokktgrgetir(lviewstok, btnfastfood);
        }

        private void btncorba_Click(object sender, EventArgs e)
        {
            Function.stokktgrgetir(lviewstok, btncorba);
        }

        private void btnmkrn_Click(object sender, EventArgs e)
        {
            Function.stokktgrgetir(lviewstok, btnmkrn);
        }

        private void btnarasck_Click(object sender, EventArgs e)
        {
            Function.stokktgrgetir(lviewstok, btnarasck);
        }
        //Buraya kadar kategori işlemlerini yazıyoruz.

        //
    }
}