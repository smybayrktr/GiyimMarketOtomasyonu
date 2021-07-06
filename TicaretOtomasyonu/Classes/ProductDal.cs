using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicaretOtomasyonu.Classes
{
    class ProductDal
    {

        SqlConnection sqlConnection = new SqlConnection("Data Source=DESKTOP-LSDB34O\\SQLSERVEREXPRESS; " +
           "initial catalog=DbETicaret; integrated security=TRUE");

        public List<Ürün> GetAll()
        {

            ConnectionControl();


            SqlCommand command = new SqlCommand("Select * from tbl_Siparisler", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<Ürün> ürünler = new List<Ürün>();
            while (reader.Read())
            {
                Ürün product = new Ürün
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    ÜrünAdi = reader["ÜrünAdi"].ToString(),
                    Beden = reader["Beden"].ToString(),
                    Renk =  reader["Renk"].ToString(),
                    Fiyat = reader["Fiyat"].ToString()


                };
                ürünler.Add(product);
            }
            reader.Close();
            sqlConnection.Close();
            return ürünler;

        }
        public List<Ürün> GetAll2()
        {

            ConnectionControl();


            SqlCommand command = new SqlCommand("Select * from tbl_Siparisler", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            List<Ürün> ürünler = new List<Ürün>();
            while (reader.Read())
            {
                Ürün product = new Ürün
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    ÜrünAdi = reader["ÜrünAdi"].ToString(),
                    Beden = reader["Beden"].ToString(),
                    Renk = reader["Renk"].ToString(),
                    Fiyat = reader["Fiyat"].ToString(),
                    Kullanici_ID = Convert.ToInt32(reader["Kullanici_ID"])


                };
                ürünler.Add(product);
            }
            reader.Close();
            sqlConnection.Close();
            return ürünler;

        }

        private void ConnectionControl()
        {
            if (sqlConnection.State == ConnectionState.Closed)
            {
                sqlConnection.Open();

            }
        }
        
        public void Delete(int id)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Delete from tbl_Siparisler where ID=@ID", sqlConnection);
            command.Parameters.AddWithValue("@ID", id);
            command.ExecuteNonQuery();

            sqlConnection.Close();

        }
    }
}
