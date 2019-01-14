using System;
using System.Collections;
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
            ////Klavyeden random sayı üretmek için deger aralıgı alıyorum 
            //Console.Write("Alt Aralık: ");
            //int alt = int.Parse(Console.ReadLine());
            //Console.Write("Ust Aralık: ");
            //int ust = int.Parse(Console.ReadLine());

            //int [] dizi=DiziUret(alt,ust);
            ////ref tipli olduğu için kolanlamak gerekebilir. 
            ////int[] klon = (int[])dizi.Clone();

            //DiziyiYazdir(dizi);
            //int enBuyuk=EnBuyukBul(dizi);
            //int enKucuk = EnKucukBul(dizi);
            //Console.WriteLine();
            //Console.WriteLine(enBuyuk);
            //Console.WriteLine(enKucuk);

            #endregion

            //Klavyeden komut satırına girilen metni şifreleyen ve şifreyi çözen programı yazınız.
            #region Soru4

            //string metin = "wxhdyz";
            //string sifreliMetin = MetniSifrele(metin);
            //string sifreCozme = MetinSifreCoz(sifreliMetin);
            #endregion

            //Parametre olarak gönderilen gün sayısının kaç yıl, kaç ay, kaç gün olduğunu hesaplayan metodu yazınız.
            #region Soru5
            //int sayi = 67;
            //string yilAyGun = YilAyGunAyir(sayi);
            #endregion

            //Smith Saysını Bulma
            #region Soru6
            int sayi = 121;
            // 1-sayının rakamları toplamı
            int sayiRakamlariToplam = sayiRakamlariToplami(sayi);

            ArrayList liste = AsalListeyiGetir(sayi);

            // 2-listenin basamakları toplamı
            int asalToplam = AsalToplamGetir(liste);

            Console.WriteLine((asalToplam == sayiRakamlariToplam) ? "Smith" : "Smith Degil"); 
            #endregion

          

        }

        //soru6
        static int AsalToplamGetir(ArrayList liste)
        {
            int asalToplam = 0;
            foreach (var item in liste)
            {
                asalToplam = asalToplam + sayiRakamlariToplami((int)item);
            }
            return asalToplam;
        }
        //soru6
        static ArrayList AsalListeyiGetir(int sayi)
        {
            ArrayList liste = new ArrayList();
            for (int i = 2; i <= sayi; i++)
            {
                if (SayiAsalMi(i))
                {
                    if (sayi % i == 0)
                    {
                        liste.Add(i);
                        sayi = sayi / i;
                        i--;
                    }
                }
            }
            return liste;
        }
        //soru6
        static int sayiRakamlariToplami(int sayi)
        {
            int toplam = 0;

            do
            {
                int kalan = sayi % 10;
                toplam = toplam + kalan;
                sayi = sayi / 10;
            } while (sayi!=0);
            return toplam;
        }
        //soru6
        private static bool SayiAsalMi(int sayi)
        {
            bool isPrime = true;
            for (int i = 2; i <= sayi/2; i++)
            {
                if(sayi%i==0)
                {
                    isPrime = false;
                    break;
                }
            }
            return isPrime;
        }

        

        //soru5
        static string YilAyGunAyir(int sayi)
        {
            int yil = sayi / 365;
            int ay = (sayi % 365) / 30;
            int gun = (sayi % 365) % 30;
            return "" + yil + " yıl " + ay + " ay " + gun + " gün ";
        }

        //soru4
        static string MetinSifreCoz(string sifreliMetin)
        {
            char[] dizi = sifreliMetin.ToCharArray();

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i].ToString().ToLower() == "a")
                {
                    dizi[i] = 'w';
                }
                else if (dizi[i].ToString().ToLower() == "b")
                {
                    dizi[i] = 'x';
                }
                else if (dizi[i].ToString().ToLower() == "c")
                {
                    dizi[i] = 'y';
                }
                else if (dizi[i].ToString().ToLower() == "d")
                {
                    dizi[i] = 'z';
                }
                else
                {
                    dizi[i] = (char)(dizi[i] - 4);
                }

            }

            return string.Concat(dizi);
        }

        //soru4
        static string MetniSifrele(string metin)
        {
            char[] dizi = metin.ToCharArray();

            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i].ToString().ToLower() == "w")
                {
                    dizi[i] = 'a';
                }
                else if (dizi[i].ToString().ToLower() == "x")
                {
                    dizi[i] = 'b';
                }
                else if (dizi[i].ToString().ToLower() == "y")
                {
                    dizi[i] = 'c';
                }
                else if (dizi[i].ToString().ToLower() == "z")
                {
                    dizi[i] = 'd';
                }
                else
                {
                    dizi[i] = (char)(dizi[i] + 4);
                }

            }

            return string.Concat(dizi);
        }

        //soru3
        static int EnKucukBul(int[] dizi)
        {
            Array.Sort(dizi);
            return dizi[0];
        }

        //soru3
        static int EnBuyukBul(int[] dizi)
        {
            Array.Sort(dizi);
            Array.Reverse(dizi);
            return dizi[0];
        }

        //soru3
        static void DiziyiYazdir(int[] dizi)
        {
            foreach (var item in dizi)
            {
                Console.Write(item + " ");
            }
        }

        //soru3
        static int[] DiziUret(int alt, int ust)
        {
            Random r = new Random();
            int[] dizi = new int[10];
            for (int i = 0; i < dizi.Length; i++)
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
                for (int i = 2; i <= sayi / 2; i++)
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
        static int Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
        }
    }
}
