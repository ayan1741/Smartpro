using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Sorular
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Girilen sayilari tersten yazdirma
            Stack yigin = new Stack();
            int sayi = 0;
            do
            {
                Console.Write("Bir Sayi Gir:");
                sayi = int.Parse(Console.ReadLine());
                if (sayi != 0)
                {
                    yigin.Push(sayi);
                }

            } while (sayi != 0);

            foreach (var item in yigin)
            {
                Console.WriteLine(item + " ");
            }
            //Pop yaptıkça count değiştiği için problem yaşanıyor...
            int l = yigin.Count;
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine(yigin.Pop());
            }
            #endregion

            #region Parantez Kontrolü
            // ---------------------parantezz kontrolu-----------------
            Console.Write("ifadeyi gir:");
            string karakter = Console.ReadLine();
            char[] dizi = karakter.ToArray();
            Stack yigin2 = new Stack();
            bool isvalid = true;
            for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] == '(')
                {
                    yigin2.Push('(');
                }
                if (dizi[i] == ')')
                {
                    if (yigin2.Count != 0)
                        yigin2.Pop();
                    else
                    {
                        isvalid = false;
                        break;
                    }
                       
                }
            }
            if (yigin2.Count == 0 && isvalid)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            #endregion
        }
    }
}
