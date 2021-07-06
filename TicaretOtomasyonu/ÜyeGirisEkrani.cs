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
    
    public partial class ÜyeGirisEkrani : DevExpress.XtraEditors.XtraForm
    {
       
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-LSDB34O\\SQLSERVEREXPRESS; " +
           "initial catalog=DbETicaret; integrated security=TRUE");
       
        public ÜyeGirisEkrani()
        {
            InitializeComponent();
        }

        private void ÜyeGirisEkrani_Load(object sender, EventArgs e)
        {

        }
        Classes.Üye üye = new Classes.Üye();
        private void btnGirisYapPersonel_Click(object sender, EventArgs e)
        {
            üye.ÜyeGirisi(txtKullaniciAdiÜye, txtSifreÜye);
            
            
        }

        private void isaratleme_CheckedChanged(object sender, EventArgs e)
        {
            if (isaratleme.CheckState==CheckState.Checked)
            {
                txtSifreÜye.UseSystemPasswordChar = true;
                isaratleme.Text = "Gizle";
            }
            else
            {
                txtSifreÜye.UseSystemPasswordChar = false;
                isaratleme.Text = "Göster";
            }
        }

        private void txtKullaniciAdiÜye_TextChanged(object sender, EventArgs e)
        {

        }
    }
}