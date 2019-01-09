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
            ////tek değer için asal mı kontrol
            //bool isPrime = AsalKontrolEt(79);
            ////0 ile 100 arası asal sayıları bulan program
            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine("{0}  -  {1}",i,AsalKontrolEt(i));
            //}
            #endregion

            //Klavyeden girilen değerler arasında rastgele sayı üreten ve bu değerleri 10 elemanlı bir dizi içerisine atayan SayiUret( ) isimli bir metot yazınız. Dizinin elemanlarını ekrana yazdıran DiziYazdir( ) isimli bir metot daha yazarak elemanları ekrana yazdırınız. Daha sonra bu dizi içerisindeki en büyük sayı değerini bulan EnBuyuk( ) isimli, en küçük değeri bulan EnKucuk( ) isimli iki metot daha yazınız. EnBuyuk ve EnKucuk metotlarından dönen sayıları ekrana yazdıran programın kodlarını yazınız.
            #region Soru3
            //Klavyeden random sayı üretmek için deger aralıgı alıyorum 
            Console.Write("Alt Aralık: ");
            int alt = int.Parse(Console.ReadLine());
            Console.Write("Ust Aralık: ");
            int ust = int.Parse(Console.ReadLine());

            int [] dizi=DiziUret(alt,ust);
            DiziyiYazdir(dizi);
            int enBuyuk=EnBuyukBul(dizi);
            int enKucuk = EnKucukBul(dizi);
            Console.WriteLine();
            Console.WriteLine(enBuyuk);
            Console.WriteLine(enKucuk);

            #endregion



        }

        static int EnKucukBul(int[] dizi)
        {
            Array.Sort(dizi);
            return dizi[0];
        }

        private static int EnBuyukBul(int[] dizi)
        {
            Array.Sort(dizi);
            Array.Reverse(dizi);
            return dizi[0];
        }

        static void DiziyiYazdir(int[] dizi)
        {
            foreach (var item in dizi)
            {
                Console.Write(item+ " ");
            }
        }

        static int[] DiziUret(int alt, int ust)
        {
            Random r = new Random();
            int[] dizi = new int[10];
            for (int i = 0; i <dizi.Length ; i++)
            {
                dizi[i] = r.Next(alt, ust); 
            }
            return dizi;
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
