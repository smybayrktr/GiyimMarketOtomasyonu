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
    public partial class Sepet : DevExpress.XtraEditors.XtraForm
    {
        public Sepet()
        {
            InitializeComponent();
            LoadSepet();
        }
        Classes.Ürünler ürünler = new Classes.Ürünler();
        Classes.ProductDal productDal = new Classes.ProductDal();
        private void Sepet_Load(object sender, EventArgs e)
        {
            LoadSepet();

        }

        private void LoadSepet ()
        {

            dgwSepet.DataSource = productDal.GetAll();
        }

        private void btnSepetiTemizle_Click(object sender, EventArgs e)
        {
                int id = Convert.ToInt32(dgwSepet.CurrentRow.Cells[0].Value);
                productDal.Delete(id);
                LoadSepet();
                MessageBox.Show("Ürün Başarıyla Silindi!",
                   "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnSepetiOnayla_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Siparişiniz Alınmıştır. Bizi Tercih Ettiğiniz İçin Teşekkürler",
               "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dgwSepet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}