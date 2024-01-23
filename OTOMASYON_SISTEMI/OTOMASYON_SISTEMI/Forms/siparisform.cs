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
    public partial class siparisform : Form
    {
        public siparisform()
        {
            InitializeComponent();
        }
        private void siparisform_Load(object sender, EventArgs e)
        {
            //form açıldığında ilgili tabloyu getiriyoruz.
            Function.tablogetir("siparis", siparistbl);
        }
    }
}