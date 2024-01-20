using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OTOMASYON_SISTEMI;

namespace OTOMASYON_SISTEMI.Forms
{
    public partial class satisform : Form
    {
        public decimal nakit, kart, açık;
        //SELECT SUM (gelir) from kasa = tutarı tek tabloya göndersin lbox oradan çeksin.
        public satisform()
        {
            InitializeComponent();
        }

        private void satisform_Load(object sender, EventArgs e)
        {
            //diğer formdaki isim değiskenini burada kullanıyoruz.
            label2.Text = "#" + masaform.isim;
            Function.urungetir(lviewmenu);
            lviewsatis.MultiSelect = false;
        }

        private void kapatbtn_Click(object sender, EventArgs e)
        {
            //bu sayfayı kapat.
            this.Close();
        }

        private void tableLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            //tbox içini temizler.
            satistbox.Clear();
            Function.urungetir(lviewmenu);
        }
        //Hesap işlemleri için buton click olaylarını ayarlıyoruz.
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
        //buraya kadar hesap işlemlerini yazıyoruz.

        //
        private void satisform_Shown(object sender, EventArgs e)
        {
            label2.Text = "#" + masaform.isim;
        }
        decimal eksilt = 0, tmp1;
        string kasa = "";
        private void iptalbtn_Click(object sender, EventArgs e)
        {
            //tablonun seçili satırına göre silme işlemini gerçekleştiriyoruz.
            // Seçili öğeyi kontrol edelim
            if (lviewsatis.SelectedItems.Count > 0)
            {
                // Seçili öğeyi sil
                ListViewItem secilifiyat = lviewsatis.SelectedItems[0];
                eksilt = Convert.ToDecimal(secilifiyat.SubItems[2].Text);
                kasa = (Convert.ToDecimal(kasa) - eksilt).ToString();
                tmp1 = Convert.ToDecimal(kasa);
                tplmttr.Text = kasa;
                ListViewItem selecteditem = lviewsatis.SelectedItems[0];
                lviewsatis.Items.Remove(selecteditem);
            }
            else
            {
                MessageBox.Show("Lütfen silinecek bir öğe seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        //Kategoriye göre veri getirme işlemlerini fonksiyon ile çağırıyoruz.
        private void btnanaymk_Click(object sender, EventArgs e)
        {
            Function.ktgrgetir(lviewmenu, btnanaymk);
        }

        private void btniçecek_Click(object sender, EventArgs e)
        {
            Function.ktgrgetir(lviewmenu, btniçecek);
        }

        private void btntatlı_Click(object sender, EventArgs e)
        {
            Function.ktgrgetir(lviewmenu, btntatlı);
        }

        private void btnyanurun_Click(object sender, EventArgs e)
        {
            Function.ktgrgetir(lviewmenu, btnyanurun);
        }

        private void btnfastfood_Click(object sender, EventArgs e)
        {
            Function.ktgrgetir(lviewmenu, btnfastfood);
        }

        private void btncorba_Click(object sender, EventArgs e)
        {
            Function.ktgrgetir(lviewmenu, btncorba);
        }

        private void btnmkrn_Click(object sender, EventArgs e)
        {
            Function.ktgrgetir(lviewmenu, btnmkrn);
        }

        private void btnarasck_Click(object sender, EventArgs e)
        {
            Function.ktgrgetir(lviewmenu, btnarasck);
        }
        //Buraya kadar kategori işlemlerini yazıyoruz.

        //
        int sayac = 0;
        decimal toplam = 0, tutar = 0, tmp;
        private void lviewmenu_DoubleClick(object sender, EventArgs e)
        {
            //tbox içinden aldığımız değer ile satis sekmesine bilgileri göderiyoruz.
            //bütün fiyatları toplayıp toplam tutar olarak gösteriyoruz.
            if (satistbox.Text == "")
            {
                satistbox.Text = "1";
            }
            if (lviewmenu.Items.Count > 0)
            {
                sayac = lviewsatis.Items.Count;
                toplam = Convert.ToDecimal(lviewmenu.SelectedItems[0].SubItems[1].Text) * Convert.ToDecimal(satistbox.Text);
                lviewsatis.Items.Add(satistbox.Text);
                lviewsatis.Items[sayac].SubItems.Add(lviewmenu.SelectedItems[0].Text);
                lviewsatis.Items[sayac].SubItems.Add(Convert.ToString(toplam));
                satistbox.Text = "";
                tutar = Convert.ToDecimal(lviewsatis.Items[sayac].SubItems[2].Text);
                tmp1 += tutar;
                tmp = tmp1;
                kasa = tmp.ToString();
                tplmttr.Text = kasa;
            }
        }

        private void nakitbtn_Click(object sender, EventArgs e)
        {
            //ödeme çeşidine göre hesap kapatma ve kasaya ekleme işlemlerini yapıyoruz.
            if (MessageBox.Show("Ödemeniz gereken tutar= " + tplmttr.Text, "HESAP", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                MessageBox.Show("Hesap başarılı bir şekilde alındı.", "TAMAMLANDI", MessageBoxButtons.OK);
                nakit = Convert.ToDecimal(tplmttr.Text);
                
            }
            else
            {
                MessageBox.Show("Hesap işlemi iptal edildi. ", "İPTAL EDİLDİ", MessageBoxButtons.OK);
            }
        }

        private void urunbulbtn_Click(object sender, EventArgs e)
        {
            //urun no suna göre veri getirme işlemlerini yapıyoruz.
            Function.urunbul(lviewmenu, satistbox);
        }

        private void kredibtn_Click(object sender, EventArgs e)
        {
            //ödeme çeşidine göre hesap kapatma ve kasaya ekleme işlemlerini yapıyoruz.
            if (MessageBox.Show("Ödemeniz gereken tutar= " + tplmttr.Text, "HESAP", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                MessageBox.Show("Hesap başarılı bir şekilde alındı.", "TAMAMLANDI", MessageBoxButtons.OK);
                kart = Convert.ToDecimal(tplmttr.Text);
                //kasaform chest = new kasaform();
                //chest.chestlbox.Items.Add(kart.ToString());
            }
            else
            {
                MessageBox.Show("Hesap işlemi iptal edildi. ", "İPTAL EDİLDİ", MessageBoxButtons.OK);
            }
        }

        private void açıkbtn_Click(object sender, EventArgs e)
        {
            //ödeme çeşidine göre hesap kapatma ve kasaya ekleme işlemlerini yapıyoruz.
            if (MessageBox.Show("Ödemeniz gereken tutar= " + tplmttr.Text, "HESAP", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                MessageBox.Show("Hesap başarılı bir şekilde alındı.", "TAMAMLANDI", MessageBoxButtons.OK);
                açık = Convert.ToDecimal(tplmttr.Text);
                //kasaform chest = new kasaform();
                //chest.chestlbox.Items.Add(açık.ToString());
            }
            else
            {
                MessageBox.Show("Hesap işlemi iptal edildi. ", "İPTAL EDİLDİ", MessageBoxButtons.OK);
            }
        }
    }
}
