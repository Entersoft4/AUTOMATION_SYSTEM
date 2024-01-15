using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTOMASYON_SISTEMI.Forms
{
    public partial class satisform : Form
    {
        public satisform()
        {
            InitializeComponent();
        }

        private void satisform_Load(object sender, EventArgs e)
        {
            label2.Text = "#" + masaform.isim;
            //
            Function.satisekle(lviewsatis, satistbox);
        }

        private void urun_btn5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void kapatbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            satistbox.Clear();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            satistbox.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            satistbox.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            satistbox.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            satistbox.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            satistbox.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            satistbox.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            satistbox.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            satistbox.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            satistbox.Text += "9";
        }

        private void btnvrgl_Click(object sender, EventArgs e)
        {
            satistbox.Text += ",";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            satistbox.Text += "0";
        }

        private void btnx_Click(object sender, EventArgs e)
        {
            satistbox.Text += "x";
        }

        private void satisform_Shown(object sender, EventArgs e)
        {
            label2.Text = "#" + masaform.isim;
        }

        private void iptalbtn_Click(object sender, EventArgs e)
        {
            //tablonun seçili satırına göre silme işlemini gerçekleştiriyoruz.
            //foreach (DataGridViewRow drow in satistbl.SelectedRows)
            //{
            //    int id = Convert.ToInt32(drow.Cells[0].Value);
            //    Function.verisil("satis", id);
            //    Function.tablogetir("satis", satistbl);
            //}
        }
    }
}
