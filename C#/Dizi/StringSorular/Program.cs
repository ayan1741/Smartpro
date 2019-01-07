using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSorular
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Return index of All Capital Letters
            {
                string metin = "mEhmeTaYaN";
                char[] diziMetin = metin.ToCharArray();
                int sayac = 0;
                //kaçtane büyük harf var onu buluyorum
                foreach (char item in diziMetin)
                {
                    if(item<='Z')
                    {
                        sayac++;
                    }
                }
                //bulduğum büyük harf kadar dizi oluşturuyorum
                int[] indexArray = new int[sayac];
                int sayac2 = 0;
                for (int i = 0; i < metin.Length; i++)
                {

                    if ((char.Parse(metin.Substring(i,1)))< 91)
                    {
                        indexArray[sayac2] = i;
                        sayac2++;
                    }
                }
                foreach (var item in indexArray)
                {
                    Console.Write(item+" ");
                }
            }
            #endregion

            #region Cümledeki 5 den büyük kelimeleri ters çeviren program
            Console.Write("Cümledeki 5 den büyük kelimeleri ters çeviren program ");
            Console.WriteLine();
            string cumle = "asdasdj skadjk sdj skadj sn skdjka";
            Console.Write(cumle);
            Console.WriteLine();

            string[] dizi = cumle.Split(' ');
            
            foreach (var item in dizi)
            {
                if(item.Length>4)
                {
                    char[] _char = item.ToArray();
                    Console.Write(string.Concat(_char.Reverse()) + " ");
                }
                else
                {
                    Console.Write(item + " ");
                }
            }
            #endregion

            #region Orta harfleri yazdıran program
            {
                Console.Write("kelime girin:");
                string kelime1 = Convert.ToString(Console.ReadLine());
                char[] dizi3 = kelime1.ToCharArray();
                if (dizi3.Length % 2 == 0)
                {
                    Console.WriteLine("karakter:{0}{1}", dizi[dizi3.Length / 2 - 1], dizi3[dizi3.Length / 2]);
                }
                else if (dizi3.Length % 2 != 0)
                {
                    Console.WriteLine("karakter:{0}", dizi3[dizi3.Length / 2]);
                }
            }
            #endregion

            #region Sesli harfleri Sayan Program

            Console.WriteLine("İçerisindeki sesli harfleri saydırmak istediğiniz cümleyi girin.");
            string kelime = Console.ReadLine();
            int sesli = 0;
            for (int i = 0; i < kelime.Length; i++)
            {
                if (kelime[i] == 'a' || kelime[i] == 'e' || kelime[i] == 'i' || kelime[i] == 'ı' || kelime[i] == 'o' || kelime[i] == 'ö' || kelime[i] == 'u' || kelime[i] == 'ü')
                {
                    sesli++;
                }
            }
            Console.WriteLine("Girilen cümledeki sesli harf sayısı: " + sesli);
            #endregion

            #region Sesli Sayan Cozum2
            {
                Console.WriteLine("Bir kelime giriniz: ");
                string kelime4 = "oo";
                string[] kelimeSay = kelime4.Split('a', 'e', 'ı', 'i', 'u', 'ü', 'o', 'ö', 'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü');
                int sayac = kelimeSay.Length - 1;
                Console.WriteLine("Metninde sesli sayısı = {0}", sayac);
                Console.ReadLine();
            }
            #endregion
        }
    }
}
