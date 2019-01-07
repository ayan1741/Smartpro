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
            //int sayi = 0;
            //ArrayList liste = new ArrayList();
            //do
            //{
            //    Console.Write("Sayi gir: ");
            //    sayi = int.Parse(Console.ReadLine());
            //    if (sayi != 0)
            //    {
            //        liste.Add(sayi);
            //    }

            //} while (sayi != 0);
            //liste.Sort();
            //liste.Reverse();
            //foreach (var item in liste)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //Console.WriteLine($"En Büyük Sayı: {liste[0]}");
            //Console.WriteLine($"En Küçük Sayı: {liste[liste.Count - 1]}");
            //double ortalama = 0;
            //int toplam = 0;
            //foreach (var item in liste)
            //{
            //    toplam = toplam + (int)item;
            //}
            //ortalama = (double)toplam / liste.Count;
            //Console.WriteLine($"Ortalama: {ortalama}");
            #endregion

            //longest squence equal numbers
            #region Soru 2
            ArrayList ardisik = new ArrayList() { 1, 2, 2, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3 };
            ArrayList index = new ArrayList();
            ArrayList kactane = new ArrayList();
            ArrayList bulunan = new ArrayList();

            int sayac = 0;

            for (int i = 0; i < ardisik.Count; i++)
            {
                int temp = i;
                for (int k = i + 1; k < ardisik.Count; k++)
                {
                    int once = (int)ardisik[i];
                    int sonra = (int)ardisik[k];
                    if (once != sonra)
                    {
                        index.Add(temp);
                        kactane.Add(++sayac);
                        break;
                    }
                    sayac++;
                    i++;
                }
                i = temp;
                sayac = 0;
            }

            //en büyük sayacın indeksini bulma
            int max = int.MinValue;
            int indis = 0;
            int enbuyukindis = 0;
            int kactanevar = 0;
            foreach (var item in kactane)
            {
                indis++;
                if((int)item>max)
                {
                    max = (int)item;
                    enbuyukindis = indis;
                    kactanevar = (int)item;
                }
            }
            //en büyük değerin indisi bulunduktan sonra hangi sayı
            int hangideger=(int)ardisik[enbuyukindis-1];
            for (int i = 0; i < kactanevar; i++)
            {
                bulunan.Add(hangideger);
            }
            #endregion

        }
    }
}
