using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifMetodlari
{
    class Kitap
    {
        public int ISBN { get; set; }
        public string Adi { get; set; }
        public string YazarAdi { get; set; }
        public string Kategori { get; set; }
        public int Fiyat { get; set; }
        public DateTime CıkısYili { get; set; }

        /// <summary>
        /// Bu metod kitap sınıfının özelliklerini ekrana yazar.
        /// </summary>
        public void EkranaYaz()
        {
            Console.WriteLine("Adı       :{0}", this.Adi);
            Console.WriteLine("Yazar Adı :{0}", this.YazarAdi);
            Console.WriteLine("Kategori  :{0}", this.Kategori);
            Console.WriteLine("Fiyat     :{0}", this.Fiyat);
            Console.WriteLine("ISBN      :{0}", this.ISBN);
            Console.WriteLine("Cıkış Yılı:{0}", this.CıkısYili);
        }

        public void EkranaYaz(Kitap kitap)
        {
            Console.WriteLine("Adı       :{0}", kitap.Adi);
            Console.WriteLine("Yazar Adı :{0}", kitap.YazarAdi);
            Console.WriteLine("Kategori  :{0}", kitap.Kategori);
            Console.WriteLine("Fiyat     :{0}", kitap.Fiyat);
            Console.WriteLine("ISBN      :{0}", kitap.ISBN);
            Console.WriteLine("Cıkış Yılı:{0}", kitap.CıkısYili);
        }

    }
}
