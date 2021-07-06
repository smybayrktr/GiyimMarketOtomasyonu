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
    public partial class ÜrünGüncelle : DevExpress.XtraEditors.XtraForm
    {
        public ÜrünGüncelle()
        {
            InitializeComponent();
        }
        Classes.Ürünler ürünler = new Classes.Ürünler();
        OpenFileDialog openFileDialog = new OpenFileDialog();
        private void btnGüncelleÜrün_Click(object sender, EventArgs e)
        {
            if (openFileDialog.FileName == "" || cbKatagoriGüncelle.Text == "" || txtAdÜrünGüncelle.Text == "" ||
                    cbBedenÜrünGüncelle.Text == "" || txtRenkÜrünGüncelle.Text == "" ||
                    txtFiyatÜrünGüncelle.Text == "" || cbKDVÜrünGüncelle.Text == "")            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ürünler.ÜrünGüncelle(openFileDialog.FileName, cbKatagoriGüncelle.Text, txtAdÜrünGüncelle.Text,
                    cbBedenÜrünGüncelle.Text, txtRenkÜrünGüncelle.Text, txtFiyatÜrünGüncelle.Text, cbKDVÜrünGüncelle.Text);
            }

        }

        private void btnResimGüncelle_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            resimEkraniÜyeGüncelle.ImageLocation = openFileDialog.FileName;
        }
    }
}