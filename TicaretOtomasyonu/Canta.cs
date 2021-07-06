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
    public partial class Canta : DevExpress.XtraEditors.XtraForm
    {
        public Canta()
        {
            InitializeComponent();
        }
        Classes.Ürünler ürünler = new Classes.Ürünler();
        private void btnSepeteEkle1_Click(object sender, EventArgs e)
        {
            ürünler.SepeteEkle(lblÜrünAd1.Text, "-", "Krem", Fiyat1.Text, 1);
        }

        private void btnSepeteEkle2_Click(object sender, EventArgs e)
        {
            ürünler.SepeteEkle(lblÜrünAd2.Text, "-", "Lacivert", Fiyat2.Text, 1);
        }

        private void btnSepeteEkle3_Click(object sender, EventArgs e)
        {
            ürünler.SepeteEkle(lblÜrünAd3.Text, "-", "Siyah", Fiyat3.Text, 1);
        }

        private void btnSepeteEkle4_Click(object sender, EventArgs e)
        {
            ürünler.SepeteEkle(lblÜrünAd4.Text, "-", "Krem", Fiyat4.Text, 1);
        }
    }
}