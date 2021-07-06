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
    public partial class DarPaca : DevExpress.XtraEditors.XtraForm
    {
        public DarPaca()
        {
            InitializeComponent();
        }
        Classes.Ürünler ürünler = new Classes.Ürünler();   
        private void btnSepeteEkle1_Click(object sender, EventArgs e)
        {
            ürünler.SepeteEkle(lblÜrünAd1.Text, Beden1.Text, "Siyah", lblFiyat1.Text, 1);
        }
    }
}