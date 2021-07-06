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
    public partial class ÜrünSil : DevExpress.XtraEditors.XtraForm
    {
        Classes.Ürünler ürünler = new Classes.Ürünler();
        public ÜrünSil()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (SilmeTiki.CheckState == CheckState.Checked && txtAdÜrünSil.Text != "")
            {
                ürünler.ÜrünSil(txtAdÜrünSil.Text);
                
            }
            else
            {
                MessageBox.Show("Lütfen Silmek İstediğinizden Emin Olunuz.");
            }
        }
    }
}