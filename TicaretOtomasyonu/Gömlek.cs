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

    public partial class Gömlek : DevExpress.XtraEditors.XtraForm
    {
        public Gömlek()
        {
            InitializeComponent();
        }
        Classes.Ürünler ürünler = new Classes.Ürünler(); 
        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            ürünler.SepeteEkle(lblÜrünAd1.Text, Beden1.Text, "Beyaz", lblFiyat1.Text, 1);
        }

        private void btnSepeteEkle2_Click(object sender, EventArgs e)
        {
            ürünler.SepeteEkle(lblÜrünAd2.Text, Beden2.Text, Renk2.Text, lblFiyat2.Text, 1);
        }
    }
}