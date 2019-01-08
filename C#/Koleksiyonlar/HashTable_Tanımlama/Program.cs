using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_Tanımlama
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hashtable tanımlama
            Hashtable htable = new Hashtable();
            Console.WriteLine($"Count :{htable.Count}");

            //Add metodu
            htable.Add(1, "Bir");
            htable.Add(2, "İki");
            htable.Add(3, "Üç");
            htable.Add(4, "Dört");
            htable.Add("Beş", "5");

            //Ekrana yazdırma
            foreach (DictionaryEntry item in htable)
            {
                Console.WriteLine(item.Key + "     " + item.Value);
                //Console.WriteLine(((DictionaryEntry)item).);
            }

            //silme işlemleri
            htable.Remove("Beş");
            //Beş Silindikten sonra
            Console.WriteLine("Beş Silindikten sonra");
            foreach (DictionaryEntry item in htable)
            {
                Console.WriteLine(item.Key + "     " + item.Value);
                //Console.WriteLine(((DictionaryEntry)item).);
            }

            //Contains 

            Console.WriteLine("Key: 7 değeri var mı?");
            if (htable.ContainsKey(7))
            {
                Console.WriteLine("7 değeri Var");
            }
            else
            {
                Console.WriteLine("7 değeri Yok");
            }
            //-----value-----
            Console.WriteLine("Value: iki değeri var mı?");
            if (htable.ContainsValue("İki"))
            {
                Console.WriteLine("iki değeri Var");
            }
            else
            {
                Console.WriteLine("iki değeri Yok");
            }
            //Keys ve Values ları arraye atma
            var array = new string[10];
            ArrayList liste = new ArrayList();
            htable.Values.CopyTo(array, 0);

            //


            foreach (var item in htable.Keys)
            {
                Console.WriteLine(htable.Keys);
            }
        }
    }
}
