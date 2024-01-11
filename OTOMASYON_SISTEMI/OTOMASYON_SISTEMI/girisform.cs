using System.Data.Sql;
using System.Data.SqlClient;
namespace OTOMASYON_SISTEMI
{
    public partial class girisform : Form
    {
        SqlConnection con;
        SqlDataReader rdr;
        SqlCommand cmd;
        public girisform()
        {
            InitializeComponent();
        }

        private void girisbtn_Click(object sender, EventArgs e)
        {
            //string password = giristbox.Text;
            //con = new SqlConnection("Data Source=DESKTOP-6BQ22BG\\SQLEXPRESS;Initial Catalog=posdb;Integrated Security=True;TrustServerCertificate=True");
            //cmd = new SqlCommand();
            //con.Open();
            //cmd.Connection=con;
            //cmd.CommandText = "Select * From Giris_Bilgi where sifre ='" + giristbox.Text + "'";
            //rdr = cmd.ExecuteReader();
            //if (rdr.Read())
            //{
                this.Hide();
                anaform main = new anaform();
                main.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Þifre hatalý lütfen tekrar deneyiniz.","Hatalý Þifre",MessageBoxButtons.OK,MessageBoxIcon.Error);
            //    giristbox.Clear();
            //}
            //con.Close();
        }

        private void girisform_Load(object sender, EventArgs e)
        {
            
        }
    }
}
