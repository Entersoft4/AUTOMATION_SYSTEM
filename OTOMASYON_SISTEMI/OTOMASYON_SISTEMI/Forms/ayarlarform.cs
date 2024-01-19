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
    public partial class ayarlarform : Form
    {
        SqlConnection con;
        SqlDataReader rdr;
        SqlCommand cmd;
        baglan join = new baglan();
        public ayarlarform()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(join.constring);
            cmd = new SqlCommand();
            /*
             DataTable gelirtable = GetgelirtipData();
             cmb_gider_tipi.DataSource = gelirtable;
             cmb_gider_tipi.DisplayMember = "gelirad";
             cmb_gider_tipi.ValueMember = "gelirkod";
            */
        }
        private void stokkontrol()
        {
            //stok tablosundan verileri getirdik.
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection(join.constring))
            {
                con.Open();
                string stock = "Select Stok_Bilgi.id, urun_ismi, Stok_Bilgi.miktar, Stok_Bilgi.birim " +
                "From Urun_Bilgi Join Stok_Bilgi on Urun_Bilgi.id = Stok_Bilgi.urun_id";
                SqlCommand cmd = new SqlCommand(stock, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable stoktablo = new DataTable();
                adapter.Fill(stoktablo);
                stoktbl.DataSource = stoktablo;
            }
        }

        private void ayarlarform_Load(object sender, EventArgs e)
        {
            //form load olduğunda yapılacak işlemleri yazıyoruz.
            //Function.tablogetir("stok", stoktbl);
            stokkontrol();
        }

        private void ssilbtn_Click(object sender, EventArgs e)
        {
            //tablonun seçili satırına göre silme işlemini gerçekleştiriyoruz.
            foreach (DataGridViewRow drow in stoktbl.SelectedRows)
            {
                int id = Convert.ToInt32(drow.Cells[0].Value);
                Function.verisil("stok", id);
                stokkontrol();
            }
            smktrtbox.Clear();
            sbrmbox.Clear();
        }

        private void stoktbl_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //tabloya tıklandığında verilerin tbox içine getirilmesi olayını ayarlıyoruz.
            int i = e.RowIndex;
            smktrtbox.Text = stoktbl.Rows[i].Cells[2].Value.ToString();
            sbrmbox.Text = stoktbl.Rows[i].Cells[3].Value.ToString();
        }

        private void sgunceltbox_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(join.constring);
            //veri güncelleme için seçili satırın bilgisini aldıktan sonra
            //ilgili tbox ların textlerine eşitleyerek gümcelliyoruz.
            foreach (DataGridViewRow drow in stoktbl.SelectedRows)
            {
                con.Open();
                string guncelle = ("Update Stok_Bilgi Set " +
                "miktar = @miktar, birim = @birim Where id = @id");
                SqlCommand cmd = new SqlCommand(guncelle, con);
                cmd.Parameters.AddWithValue("@miktar", smktrtbox.Text);
                cmd.Parameters.AddWithValue("@birim", sbrmbox.Text);
                cmd.Parameters.AddWithValue("@id", Convert.ToInt32(drow.Cells[0].Value));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Güncelleme işlemi başarılı bir şekilde gerçekleşti.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
                stokkontrol();
            }
            smktrtbox.Clear();
            sbrmbox.Clear();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void yenilebtn_Click(object sender, EventArgs e)
        {
            stokkontrol();
        }
    }
}
