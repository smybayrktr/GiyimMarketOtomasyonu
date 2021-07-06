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
    public partial class Yelek : DevExpress.XtraEditors.XtraForm
    {

        public Yelek()
        {
            InitializeComponent();
        }
        Classes.Ürünler ürünler = new Classes.Ürünler();
        private void btnYelekSepeteEkle_Click(object sender, EventArgs e)
        {
            ürünler.SepeteEkle(lblÜrünAd.Text, bedenYelek.Text, renkYelek.Text, lblFiyat.Text, 1);
        }
    }
}