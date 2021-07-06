using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace TicaretOtomasyonu
{
    public partial class İndirimSayfasi : DevExpress.XtraEditors.XtraForm
    {
        public İndirimSayfasi()
        {
            InitializeComponent();
        }
        Classes.Ürünler ürünler = new Classes.Ürünler();
        private void btnSepeteEkle1_Click(object sender, EventArgs e)
        {
                ürünler.SepeteEkle(lblÜrünAd1.Text, Beden1.Text, "Renkli", lblFiyat1.Text, 1);
            
        }

        private void btnSepeteEkle2_Click(object sender, EventArgs e)
        {
                ürünler.SepeteEkle(lblÜrünAd2.Text, Beden2.Text, "Yeşil", lblFiyat2.Text, 1);
            
        }
    }
}