using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_Sorular
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList sozluk = new SortedList() {
                {"Bugun","Today"},
                {"Yarin","Tommorrow"},
                {"Hava","Wheather" },
                {"Gokyuzu","Sky" },
                {"Karli","Snowy" },
                {"Gunesli","Sunny" },
                {"Bulutlu","Cloudy" },
                {"Acik","Clear" },
                {"Kapali","Cloudy" },
            };
            string cumle = "Bugun Hava Çok Bulutlu";
            string [] kelimeler = cumle.Split(' ');
            string ceviri = "";
            
            foreach (string kelime in kelimeler)
            {
                bool isTranslated = false;
                foreach (DictionaryEntry item in sozluk)
                {
                    if (kelime==item.Key.ToString())
                    {
                        ceviri = ceviri + " " + item.Value;
                        isTranslated = true;
                    }
                }
                if (!isTranslated)
                {
                    ceviri = ceviri + " **** ";
                }
            }
            Console.WriteLine(ceviri);







            //Console.Write("Cümle :  ");
            //string cumle = Console.ReadLine();
            //var words = cumle.Split();
            //string translated = "";
            //bool isTranslated = false;
            //foreach (var word in words)
            //{
            //    foreach (DictionaryEntry item in dictionary)
            //    {
            //        if (word.ToLower()==(item.Key).ToString().ToLower())
            //        {
            //            translated = translated + " " + (item.Value).ToString();
            //            isTranslated = true;
            //        }
            //    }
            //    if (!isTranslated)
            //    {
            //        translated = translated + "  **** ";
            //    }
            //    isTranslated = false;       
            //}
            //Console.WriteLine("Çeviri :{0}",translated);
        }
    }
}
