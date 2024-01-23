using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace OTOMASYON_SISTEMI.Forms
{
    public partial class kasaform : Form
    {
        public kasaform()
        {
            InitializeComponent();
        }
        private void kasaform_Load(object sender, EventArgs e)
        {
            //Form acildiginda listview kontrolüne son kasa durumunu yazdırıyoruz.
            Function.tablogetir("kasa", kasaveritablo);
            baglan join = new baglan();
            SqlConnection con = new SqlConnection(join.constring);
            con.Open();
            string getir = "SELECT SUM (gelir) from Kasa_Bilgi";
            using (SqlCommand cmd = new SqlCommand(getir, con))
            {
                // SqlDataReader ile sorgudan dönen veriyi okuyoruz
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    // Eğer bir satır varsa
                    if (rdr.Read())
                    {
                        lviewkasa.Items.Add(rdr[""].ToString());
                    }
                }
            }
            con.Close();
        }

        private void refreshbtn_Click(object sender, EventArgs e)
        {
            //Butona basildiginda güncel tabloyu getirmesi için yineliyoruz.
            Function.tablogetir("kasa", kasaveritablo);
            string deger;
            baglan join = new baglan();
            SqlConnection con = new SqlConnection(join.constring);
            con.Open();
            string getir = "SELECT SUM (gelir) from Kasa_Bilgi";
            using (SqlCommand cmd = new SqlCommand(getir, con))
            {
                // SqlDataReader ile sorgudan dönen veriyi okuyoruz
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    // Eğer bir satır varsa
                    if (rdr.Read())
                    {
                        lviewkasa.Items.Add(rdr[""].ToString());
                    }
                }
            }
            con.Close();
        }
    }
}