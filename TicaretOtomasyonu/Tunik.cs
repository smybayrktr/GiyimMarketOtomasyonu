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
    public partial class Tunik : DevExpress.XtraEditors.XtraForm
    {
        public Tunik()
        {
            InitializeComponent();
        }

        Classes.Ürünler ürünler = new Classes.Ürünler();
        private void btnSepeteEkle1_Click(object sender, EventArgs e)
        {
            ürünler.SepeteEkle(lblÜrünAd1.Text, beden1.Text, "Kahverengi", lblFiyat1.Text, 1);
        }

        private void btnSepeteEkle2_Click(object sender, EventArgs e)
        {
            ürünler.SepeteEkle(lblÜrünAd2.Text, beden2.Text, "Kar Melanj", lblFiyat2.Text, 1);
        }

        private void btnSepeteEkle3_Click(object sender, EventArgs e)
        {
            ürünler.SepeteEkle(lblÜrünAd3.Text, beden3.Text, renk3.Text, lblFiyat3.Text, 1);
        }
            
    }
}