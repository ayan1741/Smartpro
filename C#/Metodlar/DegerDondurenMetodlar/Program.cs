using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerDondurenMetodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //İki degeri toplayan ve int dönen metod
            #region Soru1
            //int sayi1 = 10;
            //int sayi2 = 5;
            //int toplam = Topla(sayi1, sayi2);
            //Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, toplam);
            //Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, Topla(sayi1, sayi2));
            //Console.WriteLine("{0} + {1} = {2}", sayi1, sayi2, Topla(sayi1, sayi2) + 5); 
            #endregion

            //Klavyeden girilerek parametre olarak gönderilen bir sayının, asal sayı olup olmadığını kontrol eden, eğer sayı asal ise true, değilse false değeri döndüren metodu yazınız.
            #region Soru2
            bool isPrime = AsalKontrolEt(79);
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("{0}  -  {1}",i,AsalKontrolEt(i));
            }
            #endregion

        }
        //soru2
        static bool AsalKontrolEt(int sayi)
        {
            if (sayi > 1)
            {
                bool isPrime = true;
                for (int i = 2; i <= sayi/2; i++)
                {
                    if (sayi % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                return isPrime;
            }
            else
            {
                return false;
            }
        }


        //soru1
        static int Topla(int sayi1 , int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }
    }
}
