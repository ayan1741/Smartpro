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
        }
    }
}
