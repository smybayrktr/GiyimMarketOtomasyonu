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
    public partial class Ceket : DevExpress.XtraEditors.XtraForm
    {
        public Ceket()
        {
            InitializeComponent();
        }
        Classes.Ürünler ürünler = new Classes.Ürünler();

        private void btnSepeteEkle_Click(object sender, EventArgs e)
        {
            ürünler.SepeteEkle(lblÜrünAd1.Text, Beden1.Text, "Siyah", lblFiyat1.Text, 1);
        }
    }
}