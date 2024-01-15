using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using OTOMASYON_SISTEMI.Forms;

namespace OTOMASYON_SISTEMI
{

    class Function
    {
        public static SqlConnection con;
        public static SqlDataReader rdr;
        public static SqlCommand cmd;

        public static void tablogetir(string who,DataGridView tbl)
        {
            //who ile hangi tablonun geleceğini kontrol ediyoruz.
            con = new SqlConnection("Data Source=DESKTOP-6BQ22BG\\SQLEXPRESS;Initial Catalog=posdb;Integrated Security=True;TrustServerCertificate=True");
            if (who=="masa")
            {
                string getir = "Select * From Masa_Bilgi";
                SqlCommand cmd = new SqlCommand(getir, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tbl.DataSource = dt;
                con.Close();
            }
            else if (who=="calisan")
            {
                string getir = "Select * From Calisan_Bilgi";
                SqlCommand cmd = new SqlCommand(getir, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tbl.DataSource = dt;
                con.Close();
            }
            else if (who=="urun")
            {
                string getir = "Select * From Urun_Bilgi";
                SqlCommand cmd = new SqlCommand(getir, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tbl.DataSource = dt;
                con.Close();
            }
            else if (who == "satis")
            {
                string getir = "Select * From Satis_Bilgi";
                SqlCommand cmd = new SqlCommand(getir, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tbl.DataSource = dt;
                con.Close();
            }
        }
        public static void veriekle(string who)
        {
            //who ile hangi tabloya veri ekleneceğini kontrol ediyoruz.
            //veri eklemede her tabloya varsayılan değerler ekliyoruz.
            con = new SqlConnection("Data Source=DESKTOP-6BQ22BG\\SQLEXPRESS;Initial Catalog=posdb;Integrated Security=True;TrustServerCertificate=True");
            if (who=="masa")
            {
                con.Open();
                string ekle = "insert into Masa_Bilgi values ('masa','4')";
                SqlCommand cmd=new SqlCommand(ekle, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else if (who == "calisan")
            {
                con.Open();
                string ekle = "insert into Calisan_Bilgi values ('calisan','ornek','personel','5555555555')";
                SqlCommand cmd = new SqlCommand(ekle, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else if (who == "urun")
            {
                con.Open();
                string ekle = "insert into Urun_Bilgi values ('urun','ornek','1')";
                SqlCommand cmd = new SqlCommand(ekle, con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public static void verisil(string who, int id)
        {
            //who ile hangi tablonun verisi silinecek kontrol ediyoruz.
            //veri silmede tabloda seçilen satıra göre silme işlemini gerçekleştiriyoruz.
            con = new SqlConnection("Data Source=DESKTOP-6BQ22BG\\SQLEXPRESS;Initial Catalog=posdb;Integrated Security=True;TrustServerCertificate=True");
            if (who=="masa")
            {
                con.Open();
                string sil = "Delete From Masa_Bilgi Where id = @id";
                SqlCommand cmd = new SqlCommand(sil, con);   
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close() ;
            }
            else if (who=="calisan")
            {
                con.Open();
                string sil = "Delete From Calisan_Bilgi Where id = @id";
                SqlCommand cmd = new SqlCommand(sil, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
            } 
            else if (who=="urun")
            {
                con.Open();
                string sil = "Delete From Urun_Bilgi Where id = @id";
                SqlCommand cmd = new SqlCommand(sil, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
            else if (who == "satis")
            {
                con.Open();
                string sil = "Delete From Satis_Bilgi Where id = @id";
                SqlCommand cmd = new SqlCommand(sil, con);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
        public static void veriguncelle(string who, DataGridView tbl)
        {
            //who ile hangi tablonun verisin güncelleneceğini kontrol ediyoruz.
            //veri güncellemede değerleri tbox içinden alıyoruz.
            //!güncelle butonlarında çalışan kod burada çalışmıyor.
        }
        public static void satisekle(ListView lv,TextBox tbox)
        {
            //satis yapılırken ki bilgileri ekliyoruz.
            con = new SqlConnection("Data Source=DESKTOP-6BQ22BG\\SQLEXPRESS;Initial Catalog=posdb;Integrated Security=True;TrustServerCertificate=True");
            SqlCommand cmd = new SqlCommand("Select urun_ismi, urun_ucreti From Urun_bilgi", con);
            SqlDataReader rdr = null;
            try
            {
                if (con.State==ConnectionState.Closed)
                {
                    con.Open();
                }
                rdr = cmd.ExecuteReader();
                int sayac = 0;
                while (rdr.Read())
                {
                    lv.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(rdr["urun_ucreti"])*tbox.Text.Length));
                    lv.Items.Add(rdr["urun_ismi"].ToString());
                    lv.Items[sayac].SubItems.Add(Convert.ToString(Convert.ToDecimal(rdr["urun_ucreti"])));
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
    }
}
/*con = new SqlConnection("Data Source=DESKTOP-6BQ22BG\\SQLEXPRESS;Initial Catalog=posdb;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string ekle = "insert into Satis_Bilgi (adet,urun_ismi,fiyat) values " +
            "(@adet,@urunismi,@fiyat)";
            SqlCommand cmd = new SqlCommand(ekle, con);
            cmd.Parameters.AddWithValue("@adet", tbox.Text);
            cmd.Parameters.AddWithValue("@urunismi", btn.Text);
            cmd.Parameters.AddWithValue("@fiyat", tbox.Text);// fiyatı veritabanından çek!!!
            cmd.ExecuteNonQuery();
            con.Close();
*/