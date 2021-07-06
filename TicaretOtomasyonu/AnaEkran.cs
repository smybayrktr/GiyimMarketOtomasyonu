using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicaretOtomasyonu
{
    public partial class AnaEkran : DevExpress.XtraEditors.XtraForm
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void btnÜyeOl_Click(object sender, EventArgs e)
        {
            ÜyeOlEkrani üyeOlEkrani = new ÜyeOlEkrani();
            üyeOlEkrani.Show();
            this.Hide();
        }

        private void btnPersonelGirisi_Click(object sender, EventArgs e)
        {
            PersonelGirisEkrani personelGirisi = new PersonelGirisEkrani();
            personelGirisi.Show();
            this.Hide();
        }

        private void btnÜyeGirisi_Click(object sender, EventArgs e)
        {
            ÜyeGirisEkrani üyeGirisi = new ÜyeGirisEkrani();
            üyeGirisi.Show();
            this.Hide();
        }
    }
}
