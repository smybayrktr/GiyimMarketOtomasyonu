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
    public partial class ÜyeGüncelle : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-LSDB34O\\SQLSERVEREXPRESS; " +
           "initial catalog=DbETicaret; integrated security=TRUE");
        public ÜyeGüncelle()
        {
            InitializeComponent();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
        Classes.Üye üye = new Classes.Üye();
        bool numaraDoğruMu()
        {
            long cepTelNo = long.Parse(txtTelefonNoGüncelle.Text);
            int beşMi = (int)(cepTelNo / 1000000000);
            int basamakSayısı = 1;
            for (long i = 10; i <= 1000000000; i *= 10)
            {
                int değer = (int)(cepTelNo / i);
                basamakSayısı++;
            }
            if (beşMi == 5 && basamakSayısı == 10)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private void btnÜyeGüncelle_Click(object sender, EventArgs e)
        {
            if (txtAdÜyeGüncelle.Text == "" || txtSoyadÜyeGüncelle.Text == "" || txtTelefonNoGüncelle.Text == "" ||
                txtAdresBasligiÜyeGüncelle.Text == "" || txtAdresÜyeGüncelle.Text == "" ||
                txtmailÜyeGüncelle.Text == "" || txtKullaniciAdiÜyeGüncelle.Text == "" || txtSifreÜyeGüncelle.Text == "")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (numaraDoğruMu()==false)
            {
                MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz.", "Uyarı",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtmailÜyeGüncelle.Text.Contains('@') == false)
            {
                MessageBox.Show("Geçersiz E-Mail.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string kullaniciAdi = txtKullaniciAdiÜyeGüncelle.Text;
                sqlConnection.Open();
                bool kayitliMi = false;
                SqlCommand sqlCommand = new SqlCommand("Select * from tblÜyeBilgileri ", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    if (kullaniciAdi == sqlDataReader["KullaniciAdi"].ToString())
                    {
                        kayitliMi = true;
                        break;
                    }
                }
                sqlConnection.Close();
                if (kayitliMi == true)
                {
                    üye.ÜyeGüncelle(txtAdÜyeGüncelle.Text, txtSoyadÜyeGüncelle.Text, txtTelefonNoGüncelle.Text,
                        txtAdresBasligiÜyeGüncelle.Text, txtAdresÜyeGüncelle.Text, txtmailÜyeGüncelle.Text,
                        txtKullaniciAdiÜyeGüncelle.Text, txtSifreÜyeGüncelle.Text);
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı HATALI.", "Uyarı",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            
           
        }

       
    }
}