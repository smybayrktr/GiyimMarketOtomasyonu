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
    public partial class SiparisEkrani : DevExpress.XtraEditors.XtraForm
    {
        public SiparisEkrani()
        {
            InitializeComponent();
            LoadSiparisler();
        }
        Classes.Ürünler ürünler = new Classes.Ürünler();
        Classes.ProductDal productDal = new Classes.ProductDal();
       
        private void Siarpisler_Load(object sender, EventArgs e)
        {
            LoadSiparisler();

        }

        private void LoadSiparisler()
        {
            dgwSiparisler.DataSource = productDal.GetAll2();
        }
    }
}