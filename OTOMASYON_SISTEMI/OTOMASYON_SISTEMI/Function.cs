using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTOMASYON_SISTEMI
{
    class Function
    {
        Form frm;
        Panel pnl;
        anaform main=new anaform();
        //static ile diğer taraftan ulaşılması saglanir.
        public static void formgetir(Form frm,Panel pnl,Form main)
        {
            //panelin içindekileri temizler.
            pnl.Controls.Clear();
            //MDI=Multiple Document Interface (Çoklu Belge Arayüzü)
            frm.MdiParent = main;
            //formun kenarlıklarını kaldırır ve none özelliği verir.
            frm.FormBorderStyle = FormBorderStyle.None;
            //formun bulunduğu yeri kaplaması için kullanılır.
            frm.Dock = DockStyle.Fill;
            //panel içine formu ekleme.
            pnl.Controls.Add(frm);
            //formu ekrana gösterme.
            frm.Show();
        }
    }
}
