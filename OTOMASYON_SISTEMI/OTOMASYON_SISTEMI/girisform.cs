namespace OTOMASYON_SISTEMI
{
    public partial class girisform : Form
    {
        public girisform()
        {
            InitializeComponent();
        }

        private void girisbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            anaform main=new anaform();
            main.Show();
        }
    }
}
