using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Sorular
{
    class Program
    {
        static void Main(string[] args)
        {
            //0 girilene kadar girilen değerleri ArrayListe atan ve sonunda bu listeyi büyükten küçüğe sıralayan ve listedeki en büyük en küçük ve ortalama değerleri bulan program
            #region Soru1  
            int sayi = 0;
            ArrayList liste = new ArrayList();
            do
            {
                Console.Write("Sayi gir: ");
                sayi=int.Parse(Console.ReadLine());
                if (sayi!=0)
                {
                    liste.Add(sayi); 
                }

            } while (sayi!=0);
            liste.Sort();
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.Write(item +" ");
            }
            Console.WriteLine();
            Console.WriteLine($"En Büyük Sayı: {liste[0]}");
            Console.WriteLine($"En Küçük Sayı: {liste[liste.Count-1]}");
            double ortalama = 0;
            int toplam = 0;
            foreach (var item in liste)
            {
                toplam = toplam + (int)item;
            }
            ortalama = (double)toplam / liste.Count;
            Console.WriteLine($"Ortalama: {ortalama}");
            #endregion
        }
    }
}
