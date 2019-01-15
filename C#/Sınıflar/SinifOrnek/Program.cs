using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Magaza magaza = new Magaza();
            magaza.MagazaID = 1;
            magaza.MagazaAdi = "DR";
            magaza.UrunlerEkle();

            Urun urun = new Urun();
            urun.No = 4;
            urun.Adı = "Tablet";
            urun.Fiyat = 800;
            urun.Adet = 10;
            magaza.UrunEkle(urun);

            UrunSatmaSonuc sonuc=magaza.UrunSat(1);
            if (sonuc.StokDurumu && sonuc.UrunDurumu)
            {
                Console.WriteLine("Başarılı");
            }
            else
            {
                if (!sonuc.UrunDurumu)
                {
                    Console.WriteLine("Urun yok");
                }
                else 
                {
                    Console.WriteLine("Stokta sıkıntı var");
                }
            }
        }
    }
}
