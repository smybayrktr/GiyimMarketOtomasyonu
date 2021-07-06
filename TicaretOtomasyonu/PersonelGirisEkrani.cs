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
    public partial class PersonelGirisEkrani : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-LSDB34O\\SQLSERVEREXPRESS; " +
           "initial catalog=DbETicaret; integrated security=TRUE");

        public PersonelGirisEkrani()
        {
            InitializeComponent();
        }

        private void btnGirisYapPersonel_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdiPersonel.Text;
            string sifre = txtSifrePersonel.Text;
            sqlConnection.Open();
            bool kayitliMi = false;
            SqlCommand sqlCommand = new SqlCommand("Select * from tblPersonelBilgileri ", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                if (kullaniciAdi == sqlDataReader["KullaniciAdi"].ToString() && sifre == sqlDataReader["Sifre"].ToString())
                {
                    kayitliMi = true;
                    break;
                }
            }
            sqlConnection.Close();
            if (kayitliMi == true)
            {
                PersonelEkrani personelEkrani = new PersonelEkrani();
                personelEkrani.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Sifre Hatalı!!");
            }
        }
    }
}