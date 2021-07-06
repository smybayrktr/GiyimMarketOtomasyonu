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
    public partial class Ayakkabi : DevExpress.XtraEditors.XtraForm
    {
        public Ayakkabi()
        {
            InitializeComponent();
        }
        Classes.Ürünler ürünler = new Classes.Ürünler();
        private void btnSepeteEkle1_Click(object sender, EventArgs e)
        {
                ürünler.SepeteEkle(lblürünAd1.Text, Beden1.Text, "Beyaz", lblFiyat1.Text, 1);
          
        }

        private void btnSepeteEkle2_Click(object sender, EventArgs e)
        {
                ürünler.SepeteEkle(lblÜrünAd2.Text, Beden2.Text, "Somon", lblFiyat2.Text, 1);
            
        }

        private void btnSepeteEkle3_Click(object sender, EventArgs e)
        {
                ürünler.SepeteEkle(lblÜrünAd3.Text, Beden3.Text, "Siyah", lblFiyat3.Text, 1);
            
        }

        private void btnSepeteEkle4_Click(object sender, EventArgs e)
        {
                ürünler.SepeteEkle(lblÜrünAd4.Text, Beden4.Text, "Bej", lblFiyat4.Text, 1);
            
        }
    }
}