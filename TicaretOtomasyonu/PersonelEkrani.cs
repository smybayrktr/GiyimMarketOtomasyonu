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
    public partial class PersonelEkrani : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        Dictionary<string, Form> dictionary;

        public PersonelEkrani()
        {
            InitializeComponent();
            dictionary = new Dictionary<string, Form>();
        }
        public void FormYükle(string isim)
        {
            Form form = null;
            if (dictionary.ContainsKey(isim))
            {
                form = this.dictionary[isim];
                form.WindowState = FormWindowState.Normal;
                form.Activate();
                Sakla();
            }
            else
            {
                switch (isim)
                {
                    case "ÜrünEkle":
                        form = new ÜrünEkle();
                        break;
                    case "ÜrünGüncelle":
                        form = new ÜrünGüncelle();
                        break;
                    case "ÜrünSil":
                        form = new ÜrünSil();
                        break;
                    case "SiparisEkrani":
                        form = new SiparisEkrani();
                        break;

                }
                dictionary.Add(isim, form);
                form.MdiParent = this;
                form.Show();
                Sakla();
            }

        }
        public void Sakla()
        {
            xtrPersonelEkrani.Hide();
        }



        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormYükle("ÜrünEkle");
        }
        
        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormYükle("ÜrünGüncelle");
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormYükle("ÜrünSil");
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FormYükle("SiparisEkrani");
        }
    }
}