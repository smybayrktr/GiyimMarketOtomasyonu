using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicaretOtomasyonu.Classes
{
    class Ürün
    {
        public int ID { get; set; } 
        public string ÜrünAdi { get; set; }
        public string Beden { get; set; }
        public string Fiyat { get; set; }
        public string Renk { get; set; }

        public int Kullanici_ID { get; set; }
    }
}
