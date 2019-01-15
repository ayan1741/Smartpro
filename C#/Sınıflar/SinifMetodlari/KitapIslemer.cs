using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifMetodlari
{
    class KitapIslemer
    {
        public void EkranaYaz(Kitap kitap)
        {
            Console.WriteLine("Adı       :{0}", kitap.Adi);
            Console.WriteLine("Yazar Adı :{0}", kitap.YazarAdi);
            Console.WriteLine("Kategori  :{0}", kitap.Kategori);
            Console.WriteLine("Fiyat     :{0}", kitap.Fiyat);
            Console.WriteLine("ISBN      :{0}", kitap.ISBN);
            Console.WriteLine("Cıkış Yılı:{0}", kitap.CıkısYili);
        }

        public void Add(Kitap kitap,Magaza magaza)
        {
            
            magaza.Kitaplar.Add(kitap);
        }
    }
}
