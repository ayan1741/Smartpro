using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifMetodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            Kitap kitap = new Kitap();
            kitap.Adi = "Ruzgarın Adi";
            kitap.Kategori = "Fantastik";
            kitap.YazarAdi = "Patrick";
            kitap.ISBN = 123;
            kitap.Fiyat = 35;
            kitap.CıkısYili = DateTime.Now;

            kitap.EkranaYaz();
            //-------------------------------
            Magaza magaza = new Magaza();

            magaza.MagazaID = 999;
            magaza.MagazaAdi = "DR";

            Adres adres = new Adres();
            adres.Il = "İstanbul";
            adres.Ilce = "Kartal";
            adres.Mahalle = "Yeni";

            magaza.Adres = adres;
            magaza.Kitaplar.Add(kitap);
            magaza.Kitaplar.Add(kitap);
            magaza.Kitaplar.Add(kitap);
            magaza.Kitaplar.Add(kitap);

            magaza.MagazaKitaplariYazdir();

            kitap = new Kitap();
            kitap.Adi = "Ruzgarın Adi2";
            kitap.Kategori = "Fantastik";
            kitap.YazarAdi = "Patrick";
            kitap.ISBN = 123;
            kitap.Fiyat = 35;
            kitap.CıkısYili = DateTime.Now;

            KitapIslemer kislem = new KitapIslemer();
            kislem.Add(kitap, magaza);


        }
    }
}
