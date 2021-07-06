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
    public partial class ÜyeOlEkrani : DevExpress.XtraEditors.XtraForm
    {
        public ÜyeOlEkrani()
        {
            InitializeComponent();
        }
        Classes.Üye yeniÜye = new Classes.Üye();
        private void btnÜyeOl_Click(object sender, EventArgs e)
        {
            yeniÜye.ÜyeOl(txtAdÜyeOl.Text,txtSoyadÜyeOl.Text,txtTelefonNoÜyeOl.Text,txtAdresBasligiÜyeOl.Text,
                     txtAdresÜyeOl.Text, txtmailÜyeOl.Text, txtKullaniciAdiÜyeOl.Text, txtSifreÜyeOl.Text, txtSifreTekrarÜyeOl.Text);
            
        }
    }
}