using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMetodlari
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin1 = "byte";
            string metin2 = "Byte";
            int sonuc = string.Compare(metin1,metin2);
            Console.WriteLine($"string.Compare({metin1},{metin2})");
            Console.WriteLine($"{metin1} ile {metin2} = {sonuc}");

            //case duyarlı değil
            int sonuc2 = string.Compare(metin1, metin2,true);
            Console.WriteLine($"string.Compare({metin1},{metin2},true)");
            Console.WriteLine($"{metin1} ile {metin2} = {sonuc2}");

            //concat
            string sonuc3 = string.Concat(metin1, metin2);
            Console.WriteLine($"string.Concat({metin1},{metin2})");
            Console.WriteLine($"{metin1} ile {metin2} = {sonuc3}");

            //indexof
            int sonuc4 = metin1.IndexOf("yt");
            Console.WriteLine($"metin1.IndexOf(yt)");
            Console.WriteLine($"{metin1} içerisinde yt = {sonuc4}");

            //startwith
            bool sonuc5 = metin1.StartsWith("by");
            Console.WriteLine($"metin1.StartsWith(by)");
            Console.WriteLine($"{metin1} by ile başlıyor mu? = {sonuc5}");

            //trim
            string sonuc6 = metin1.Trim().Trim('b');
            Console.WriteLine($"metin1.Trim()");
            Console.WriteLine($"{metin1}  trim = {sonuc6}");

            //remove
            string sonuc7 = metin1.Remove(2);
            Console.WriteLine($"metin1.Remove(2)");
            Console.WriteLine($"{metin1}  remove = {sonuc7}");

            //split
            Console.WriteLine("Split------");
            Console.WriteLine("Merhaba dünya. Nasılsın, iyi misin");
            string metin = "Merhaba dünya. Nasılsın, iyi misin";
            string [] dizi=metin.Split('a');
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }

            //join
            Console.WriteLine("join a dan sonra");
            string mtn=string.Join(",", dizi);
            Console.WriteLine(mtn);
        }
    }
}
