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
    public partial class ÜrünEkle : DevExpress.XtraEditors.XtraForm
    {
        public ÜrünEkle()
        {
            InitializeComponent();
        }

        OpenFileDialog openFileDialog = new OpenFileDialog();
       
        Classes.Ürünler ürünler = new Classes.Ürünler();
      
        private void xtrPersonelEkrani_Load(object sender, EventArgs e)
        {

        }

        private void btnResim_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            resimEkraniÜye.ImageLocation = openFileDialog.FileName;
        }
        
        private void btnKaydetÜrün_Click(object sender, EventArgs e)
        {
            ürünler.ÜrünEkle(openFileDialog.FileName, cbKatagoriÜrün.Text, txtAdÜrün.Text, cbBedenÜrün.Text, txtRenkÜrün.Text, txtFiyatÜrün.Text, cbKDVÜrün.Text);

        }
    }
}