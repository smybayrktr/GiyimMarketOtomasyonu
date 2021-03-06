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
using System.Data.SqlClient;

namespace TicaretOtomasyonu
{
    public partial class Hirka : DevExpress.XtraEditors.XtraForm
    {
        public Hirka()
        {
            InitializeComponent();
        }
        Classes.Ürünler ürünler = new Classes.Ürünler();

        private void btnSepeteEkle1_Click(object sender, EventArgs e)
        {
            ürünler.SepeteEkle(lblÜrünAd1.Text, beden1.Text, "Gri", lblFiyat1.Text, 1);
        }

        private void btnSepeteEkle2_Click(object sender, EventArgs e)
        {
            ürünler.SepeteEkle(lblÜrünAd2.Text, cbBeden2.Text, "Kahverengi", lblFiyat2.Text, 1);
        }

        private void btnSepeteEkle3_Click(object sender, EventArgs e)
        {
            ürünler.SepeteEkle(lblÜrünAd3.Text, cbBeden3.Text, "Kırmızı", lblFiyat3.Text, 1);
        }

        private void btnSepeteEkle4_Click(object sender, EventArgs e)
        {
            ürünler.SepeteEkle(lblÜrünAd4.Text, cbBeden4.Text, "Yeşil", lblFiyat4.Text, 1);
        }
    }
}