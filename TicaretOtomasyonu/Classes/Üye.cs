using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicaretOtomasyonu.Classes
{
    class Üye
    {
        SqlConnection sqlConnection = new SqlConnection(Veritabani.yol);
        
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string AdresBasligi { get; set; }
        public string Adres { get; set; }
        public string EMail { get; set; }
        public string TelefonNo { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }

        public void ÜyeGirisi (TextBox txtKullaniciAdiÜye, TextBox txtSireÜye )
        {
            if (txtKullaniciAdiÜye.Text=="" || txtSireÜye.Text=="")
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Boş Geçilemez.","Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("Select * from tblÜyeBilgileri where KullaniciAdi='"
                    +txtKullaniciAdiÜye.Text +"' and Sifre='"+txtSireÜye.Text+"'", sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                if (sqlDataReader.Read())
                {
                    ÜyeEkrani üyeEkrani = new ÜyeEkrani();
                    ÜyeGirisEkrani.ActiveForm.Visible = false;
                    üyeEkrani.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı!","Uyarı-2",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                sqlConnection.Close();

            }
        }

        public void ÜyeOl(string _ad, string _soyad, string _telNo, string _adresBasligi, string _adres, string _eMail, string _kullaniciAdi, string _sifre,string _sifreTekrar )
        {
            Ad = _ad;
            Soyad = _soyad;
            TelefonNo = _telNo;
            AdresBasligi = _adresBasligi;
            Adres = _adres;
            EMail = _eMail;
            KullaniciAdi = _kullaniciAdi;
            Sifre = _sifre;
            if (numaraDoğruMu()==false)
            {
                MessageBox.Show("Lütfen 5 ile başlayan 10 haneli cep telefonu numaranızı giriniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_eMail.Contains('@') == false)
            {
                MessageBox.Show("Geçersiz E-Mail.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_ad == "" || _soyad =="" || _telNo =="" ||_adresBasligi==""||_adres=="" || _eMail==""|| 
                _kullaniciAdi =="" || _sifre == "" || _sifreTekrar =="")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Sifre!=_sifreTekrar)
            {
                MessageBox.Show("Şifreleriniz Eşleşmiyor.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO tblÜyeBilgileri(Ad,Soyad,Adres,AdresBasligi,TelefonNo,EMail,KullaniciAdi,Sifre) VALUES (@Ad,@Soyad,@Adres,@AdresBasligi,@TelefonNo,@EMail,@KullaniciAdi,@Sifre) ", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Ad", _ad);
                sqlCommand.Parameters.AddWithValue("@Soyad", _soyad);
                sqlCommand.Parameters.AddWithValue("@Adres", _adres);
                sqlCommand.Parameters.AddWithValue("@AdresBasligi", _adresBasligi);
                sqlCommand.Parameters.AddWithValue("@TelefonNo", _telNo);
                sqlCommand.Parameters.AddWithValue("@EMail", _eMail);
                sqlCommand.Parameters.AddWithValue("@KullaniciAdi", _kullaniciAdi);
                sqlCommand.Parameters.AddWithValue("@Sifre", _sifre);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Başarıyla Üye Oldunuz. Kullanıcı Girişine Yönlendiriliyorsunuz",
                    "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ÜyeGirisEkrani üyeGirisi = new ÜyeGirisEkrani();
                ÜyeOlEkrani.ActiveForm.Visible = false;
                üyeGirisi.Show();
                
            }
            bool numaraDoğruMu()
            {
                long cepTelNo = long.Parse(TelefonNo) ;
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
            
        }

        public void ÜyeGüncelle(string _ad, string _soyad, string _telNo, string _adresBasligi, string _adres, string _eMail, string _kullaniciAdi, string _sifre)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update tblÜyeBilgileri set Ad=@Ad, " +
                "Soyad=@Soyad,  AdresBasligi=@AdresBasligi,  Adres =@Adres, TelefonNo=@TelefonNo, EMail=@EMail, Sifre=@Sifre where KullaniciAdi=@KullaniciAdi", sqlConnection);
            command.Parameters.AddWithValue("@Ad", _ad);
            command.Parameters.AddWithValue("@Soyad", _soyad);
            command.Parameters.AddWithValue("@AdresBasligi", _adresBasligi);
            command.Parameters.AddWithValue("@Adres", _adres);
            command.Parameters.AddWithValue("@TelefonNo", _telNo);
            command.Parameters.AddWithValue("@EMail", _eMail);
            command.Parameters.AddWithValue("@KullaniciAdi", _kullaniciAdi);
            command.Parameters.AddWithValue("@Sifre", _sifre);
            command.ExecuteNonQuery();

            sqlConnection.Close();
            MessageBox.Show("Güncellendi!",
                    "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        
        private void ConnectionControl()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();

            }
        }
    }
}
