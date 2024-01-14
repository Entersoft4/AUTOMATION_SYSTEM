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

        private void masa1_Click(object sender, EventArgs e)
        {
            isim = masa1.Text;
            sales.Size=new Size(1257, 556);
            sales.Show();
        }
    }
}
