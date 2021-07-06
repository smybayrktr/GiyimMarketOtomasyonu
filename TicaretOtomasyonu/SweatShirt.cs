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
    public partial class SweatShirt : DevExpress.XtraEditors.XtraForm
    {
        Classes.Ürünler ürünler = new Classes.Ürünler();
        public SweatShirt()
        {
            InitializeComponent();
        }

        private void btnSepeteEkle1_Click(object sender, EventArgs e)
        {
            ürünler.SepeteEkle(lblÜrünAd1.Text, beden1.Text, "Siyah", lblFiyat1.Text, 1);
        }

        private void btnSepeteEkle2_Click(object sender, EventArgs e)
        {
            ürünler.SepeteEkle(lblÜrünAd2.Text, beden2.Text, "Lacivert", lblFiyat2.Text, 1);
        }

        private void btnSepeteEkle3_Click(object sender, EventArgs e)
        {
            ürünler.SepeteEkle(lblÜrünAd3.Text, beden3.Text, "Gri", lblFiyat3.Text, 1);
        }

        private void btnSepeteEkle4_Click(object sender, EventArgs e)
        {
            ürünler.SepeteEkle(lblÜrünAd4.Text, beden4.Text, "Gri", lblFiyat4.Text, 1);
        }
    }
}