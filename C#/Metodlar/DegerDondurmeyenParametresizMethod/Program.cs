using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerDondurmeyenParametresizMethod
{
    class Program
    {
        

        static void Main(string[] args)
        {
            //Geri dönüş değeri ve parametre-listesi boş olan, ekrana “Merhaba Dünya” yazdıran metodu tanımlayıp program içerisinde kullanımına bir örnek veriniz.
            //#region Soru 1
            //MerhabaDunyaYaz();

            //#endregion
            //----------------------------------------------------------------------------------------
            //Klavyeden girilen bir tam sayının karesini ekrana yazan  metodu ve bu metodun program içerisinde kullanımını gösteren programın kodunu yazınız.
            #region MyRegion
            Console.Write("Bir Sayı Gir:");
            int sayi=int.Parse(Console.ReadLine());
            KareAl2(sayi);
            #endregion

            //Klavyeden girilen bir mesajı ekrana N defa yazdıran metodun kodunu yazınız.
            #region MyRegion
            Console.Write("Yazı:");
            string yazi = Console.ReadLine();
            Console.Write("Kaç Defa:");
            int kacDefa = int.Parse(Console.ReadLine());
            NDefaYaz(yazi, kacDefa);
            #endregion
        }

        static void NDefaYaz(string neYazilacak,int kacDefaYazilacak)
        {
            for (int i = 0; i < kacDefaYazilacak; i++)
            {
                Console.WriteLine(neYazilacak);
            }
        }

        static void MerhabaDunyaYaz()
        {
            Console.WriteLine("Merhaba Dünya");
        }

        static void KareAl(int sayi)
        {
            Console.WriteLine($"Verilen {sayi}'nın karesi {sayi * sayi}'dır.");
        }

        static void KareAl2(int sayi)
        {
            Console.WriteLine($"Verilen {sayi}'nın karesi {sayi * sayi}'dır.");
        }

    }
}
