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
    class Ürünler
    {
        public string ürünAdi { get; set; }

        public string beden { get; set; }
        public string fiyat { get; set; }
        public string KDV { get; set; }
        public string resim { get; set; }
        public string renk { get; set; }
        public string katagori { get; set; }
        public int Kullanici_ID { get; set; }
        public int ID { get; set; }

        SqlConnection sqlConnection = new SqlConnection(Veritabani.yol);

        public void ÜrünEkle(string _resim, string _katagori,string _ürünAd, string _beden, string _renk, string _fiyat, string _KDV)
        {
            ürünAdi = _ürünAd;
            beden = _beden;
            fiyat = _fiyat;
            KDV = _KDV;
            resim = _resim;
            renk = _renk;
            katagori = _katagori;
            
            if (_ürünAd == "" || _beden == "" || _fiyat == "" || _KDV.ToString() == "" || _resim == "" || _renk == "" || _katagori =="" )
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO tblÜrünler(ÜrünAdi,Beden,Fiyat,KDV,ÜrünResmi,Renk,Katagori) VALUES (@ürünAdi,@beden,@fiyat,@KDV,@resim,@renk,@katagori) ", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@ürünAdi", _ürünAd);
                sqlCommand.Parameters.AddWithValue("@beden", _beden);
                sqlCommand.Parameters.AddWithValue("@fiyat", _fiyat);
                sqlCommand.Parameters.AddWithValue("@KDV", _KDV);
                sqlCommand.Parameters.AddWithValue("@resim", _resim);
                sqlCommand.Parameters.AddWithValue("@renk", _renk);
                sqlCommand.Parameters.AddWithValue("@katagori", _katagori);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Ürün Kaydedildi",
                    "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            
        }
        public void ÜrünGüncelle(string _resim, string _katagori, string _ürünAd, string _beden, string _renk, string _fiyat, string _KDV)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Update tblÜrünler set Fiyat=@fiyat," +
                "Beden=@beden, KDV=@KDV, ÜrünResmi =@ÜrünResmi, Renk=@renk, Katagori=@katagoriAdi where ÜrünAdi=@ürünAdi", sqlConnection);
            command.Parameters.AddWithValue("@ürünAdi", _ürünAd);
            command.Parameters.AddWithValue("@fiyat", _fiyat);
            command.Parameters.AddWithValue("@beden", _beden);
            command.Parameters.AddWithValue("@KDV", _KDV);
            command.Parameters.AddWithValue("@ÜrünResmi", _ürünAd);
            command.Parameters.AddWithValue("@renk", _renk);
            command.Parameters.AddWithValue("@katagoriAdi", _katagori);
            command.ExecuteNonQuery();
            MessageBox.Show("Güncellendi!",
                    "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sqlConnection.Close();
        }
        public void ÜrünSil(string _ürünAd)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from tblÜrünler where ÜrünAdi=@ÜrünAdi", sqlConnection);
            command.Parameters.AddWithValue("@ürünAdi", _ürünAd);
            command.ExecuteNonQuery();
            MessageBox.Show("Ürün Başarıyla Silindi!",
                   "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            sqlConnection.Close();

        }
        private void ConnectionControl()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();

            }
        }
        public void SepeteEkle (string _ürünAd, string _beden, string _renk, string _fiyat, int _kullaniciID)
        {
            ürünAdi = _ürünAd;
            beden = _beden;
            renk = _renk;
            fiyat = _fiyat;
            Kullanici_ID = _kullaniciID;
            if (_beden=="")
            {
                MessageBox.Show("Lütfen Beden Seçimi Yapınız.",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (_renk=="")
            {
                MessageBox.Show("Lütfen Renk Seçimi Yapınız.",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (_beden.Contains("Tükendi"))
            {
                MessageBox.Show("Ürün Tükenmiştir.",
                    "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand("INSERT INTO tbl_Siparisler(ÜrünAdi,Beden,Fiyat,Renk,Kullanici_ID) VALUES (@ürünAdi,@beden,@fiyat,@renk,@KullaniciID) ", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@ürünAdi", _ürünAd);
                sqlCommand.Parameters.AddWithValue("@beden", _beden);
                sqlCommand.Parameters.AddWithValue("@fiyat", _fiyat);
                sqlCommand.Parameters.AddWithValue("@renk", _renk);
                sqlCommand.Parameters.AddWithValue("@KullaniciID", _kullaniciID);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Ürün Sepete Eklendi",
                    "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            }
                
        }

    }
}
