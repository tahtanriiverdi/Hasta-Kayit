using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TahaProjehastakyt
{
    public class Hastalar
    {
        public Guid ID { get; set; }

        public Guid DoktorlarimizID { get; set; }


        public string Ad { get; set; } 

        public string Soyad { get; set; }

        public string doktorid { get; set; }

        public string Odano { get; set;}

        public string Yatakno { get; set;}
        
        //doktorid ekledim sonradan

        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }

    }
    public class Doktorlar
    {
        public Guid ID { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }

        public string Brans { get; set; }
        public override string ToString()
        {
            return $"{Ad} {Soyad} {Brans}";
        }

    }
    public class Tedavitarih
    {
        public Guid ID { get; set; }

        public Guid HastalarimizID { get; set;}

        public Guid DoktorlarimizID { get; set;}

        public DateTime Tarih { get; set; }
    }
    public class Laboratuvarsonuc
    {
        public Guid ID { get; set; }

        public Hastalar Hastalar { get; set;}

        public string Testad { get; set; }

        public string Sonuc { get; set; }

        public DateTime Tarih { get; set; }
    }
    public class Yoneticiler
    {
        public Guid ID { get; set; }

        public string Ad { get; set; }

        public string Soyad { get; set; }
        public string kullaniciad { get; set; }

        public string parola { get; set; }

    }
}
