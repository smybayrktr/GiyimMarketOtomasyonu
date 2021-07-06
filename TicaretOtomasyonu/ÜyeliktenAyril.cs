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
    public partial class ÜyeliktenAyril : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-LSDB34O\\SQLSERVEREXPRESS; " +
           "initial catalog=DbETicaret; integrated security=TRUE");
        public ÜyeliktenAyril()
        {
            InitializeComponent();
        }
        
        private void btnÜyeSil_Click(object sender, EventArgs e)
        {
            if (ÜyeliktenAyrilmaTiki.CheckState == CheckState.Checked)
            {
                string kullaniciAdi = txtKullaniciAdiSil.Text;
                string sifre = txtSifreSil.Text;
                sqlConnection.Open();
                bool sifreDogruMu = false;
                SqlCommand sqlCommand1 = new SqlCommand("Select * from tblÜyeBilgileri ", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand1.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    if (kullaniciAdi == sqlDataReader["KullaniciAdi"].ToString() && sifre == sqlDataReader["Sifre"].ToString())
                    {
                        sifreDogruMu = true;
                        break;

                    }
                }
                sqlConnection.Close();
                if (sifreDogruMu == true)
                {
                    string sorgu = "DELETE FROM tblÜyeBilgileri WHERE KullaniciAdi=@KullaniciAdi";
                    SqlCommand sqlCommand = new SqlCommand(sorgu, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@KullaniciAdi", txtKullaniciAdiSil.Text);
                    sqlConnection.Open();
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Bilgileriniz Başarıyla Silindi. Girişe Yönlendiriliyosunuz.");
                    ÜyeGirisEkrani.ActiveForm.Visible = false;
                    AnaEkran anaEkran = new AnaEkran();
                    anaEkran.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Sifre Hatalı.", "Uyarı",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Lütfen Tüm Alanları Doldurunuz.", "Uyarı",
                          MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}