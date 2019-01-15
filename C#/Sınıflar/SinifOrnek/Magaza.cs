using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifOrnek
{
    class Magaza
    {
        public int MagazaID { get; set; }
        public string MagazaAdi { get; set; }
        public ArrayList Urunler { get; set; } = new ArrayList();

        public void UrunlerEkle()
        {
            string secim = "";
            do
            {
                Urun urun = new Urun();
                Console.Write("Urun ID     :");
                urun.No = int.Parse(Console.ReadLine());
                Console.Write("Urun Adı    :");
                urun.Adı = Console.ReadLine();
                Console.Write("Urun Fiyatı :");
                urun.Fiyat = int.Parse(Console.ReadLine());
                Console.Write("Urun Adet   :");
                urun.Adet = int.Parse(Console.ReadLine());
                Urunler.Add(urun);
                Console.Write("Urununuz basarili bir sekilde eklendi");
                Console.Write("Baska urun eklemek istermisin (e/h)");
                secim = Console.ReadLine();

            } while (secim.ToLower() == "e");

        }

        public void UrunEkle(Urun urun)
        {
            Urunler.Add(urun);
        }

        //Urun Sat
        public UrunSatmaSonuc UrunSat(int id)
        {
            UrunSatmaSonuc sonuc = new UrunSatmaSonuc();
           
            foreach (var urun in Urunler)
            {
                if (((Urun)urun).No == id)
                {
                    sonuc.UrunDurumu = true;
                    if(((Urun)urun).Adet>0)
                    {
                        ((Urun)urun).Adet--;
                        sonuc.StokDurumu = true;
                        break;
                    }
                }
            }
            return sonuc;
        }
    }
}
