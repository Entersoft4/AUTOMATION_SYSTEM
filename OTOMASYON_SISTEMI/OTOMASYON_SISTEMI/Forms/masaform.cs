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
    public partial class masaform : Form
    {
        public masaform()
        {
            InitializeComponent();
        }
        public static string isim;
        satisform sales = new satisform();
        public void frmgtr(Button btn)
        {
            isim = btn.Text;
            if (sales.IsDisposed)
            {
                // Yok edilmişse, yeni bir örnek oluştur
                sales = new satisform();
            }
            sales.Size = new Size(1257, 556);
            sales.Show();
        }

        private void masa1_Click(object sender, EventArgs e)
        {
            frmgtr(masa1);
        }

        private void masa2_Click(object sender, EventArgs e)
        {
            frmgtr(masa2);
        }

        private void masa3_Click(object sender, EventArgs e)
        {
            frmgtr(masa3);
        }

        private void masa4_Click(object sender, EventArgs e)
        {
            frmgtr(masa4);
        }

        private void masa5_Click(object sender, EventArgs e)
        {
            frmgtr(masa5);
        }

        private void masa6_Click(object sender, EventArgs e)
        {
            frmgtr(masa6);
        }

        private void masa7_Click(object sender, EventArgs e)
        {
            frmgtr(masa7);
        }

        private void masa8_Click(object sender, EventArgs e)
        {
            frmgtr(masa8);
        }

        private void masa9_Click(object sender, EventArgs e)
        {
            frmgtr(masa9);
        }

        private void masa10_Click(object sender, EventArgs e)
        {
            frmgtr(masa10);
        }

        private void masa11_Click(object sender, EventArgs e)
        {
            frmgtr(masa11);
        }

        private void masa12_Click(object sender, EventArgs e)
        {
            frmgtr(masa12);
        }

        private void masa13_Click(object sender, EventArgs e)
        {
            frmgtr(masa13);
        }

        private void masa14_Click(object sender, EventArgs e)
        {
            frmgtr(masa14);
        }

        private void masa15_Click(object sender, EventArgs e)
        {
            frmgtr(masa15);
        }

        private void masa16_Click(object sender, EventArgs e)
        {
            frmgtr(masa16);
        }

        private void masa17_Click(object sender, EventArgs e)
        {
            frmgtr(masa17);
        }

        private void masa18_Click(object sender, EventArgs e)
        {
            frmgtr(masa18);
        }

        private void masa19_Click(object sender, EventArgs e)
        {
            frmgtr(masa19);
        }

        private void masa20_Click(object sender, EventArgs e)
        {
            frmgtr(masa20);
        }

        private void masa21_Click(object sender, EventArgs e)
        {
            frmgtr(masa21);
        }

        private void masa22_Click(object sender, EventArgs e)
        {
            frmgtr(masa22);
        }

        private void masa23_Click(object sender, EventArgs e)
        {
            frmgtr(masa23);
        }

        private void masa24_Click(object sender, EventArgs e)
        {
            frmgtr(masa24);
        }

        private void masa25_Click(object sender, EventArgs e)
        {
            frmgtr(masa25);
        }
    }
}