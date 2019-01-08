using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedList_Tanimlama
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
            // Getbyindex 
            object gelen=sozluk.GetByIndex(0);
            string a = gelen as string;

            //indexof 
            int index=sozluk.IndexOfKey("Acik");
            int index2 = sozluk.IndexOfValue("Tommorrow");

            //Setbyindex
            sozluk.SetByIndex(0, "Acik");

            //GetValueList
            IList liste=sozluk.GetValueList();
          
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Clone
            SortedList temp = sozluk;
            temp["Acik"] = "Kapali";

            object clone=sozluk.Clone();
            SortedList sss=(SortedList)clone;
            sss["Kapali"] = "Clone";
        }
    }
}
