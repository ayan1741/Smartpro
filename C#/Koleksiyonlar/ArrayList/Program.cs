using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList tanımlama
            ArrayList liste = new ArrayList();
            Console.WriteLine($"Capacity: {liste.Capacity}");
            Console.WriteLine($"Count: {liste.Count}");

            //Veri Ekleme
            liste.Add('a');
            Console.WriteLine($"----Güncellem-----");
            Console.WriteLine($"Capacity: {liste.Capacity}");
            Console.WriteLine($"Count: {liste.Count}");
            liste.Add(1);
            liste.Add(true);
            liste.Add("aaa");
            Console.WriteLine($"----Güncellem-----");
            Console.WriteLine($"Capacity: {liste.Capacity}");
            Console.WriteLine($"Count: {liste.Count}");
            liste.Add("dsds");
            Console.WriteLine($"----Güncellem-----");
            Console.WriteLine($"Capacity: {liste.Capacity}");
            Console.WriteLine($"Count: {liste.Count}");

            foreach (var item in liste)
            {
                Console.Write(item + " ");
            }

            //Silme işlemi
            liste.Remove("dsds");
            Console.WriteLine($"----Güncelleme-----");
            Console.WriteLine($"Capacity: {liste.Capacity}");
            Console.WriteLine($"Count: {liste.Count}");

            foreach (var item in liste)
            {
                Console.Write(item + " ");
            }

            //Silme işleme indexli
            liste.RemoveAt(0);
            Console.WriteLine($"----Güncellem-----");
            Console.WriteLine($"Capacity: {liste.Capacity}");
            Console.WriteLine($"Count: {liste.Count}");

            foreach (var item in liste)
            {
                Console.Write(item + " ");
            }

            //silme 3
            liste.RemoveRange(0, 2);
            Console.WriteLine($"----Güncellem-----");
            Console.WriteLine($"Capacity: {liste.Capacity}");
            Console.WriteLine($"Count: {liste.Count}");

            foreach (var item in liste)
            {
                Console.Write(item + " ");
            }

            //trimtosize
            liste.TrimToSize();
            Console.WriteLine($"----Güncellem-----");
            Console.WriteLine($"Capacity: {liste.Capacity}");
            Console.WriteLine($"Count: {liste.Count}");

            //AddRange
            var dizi = new int[4] { 1, 2, 3, 4 };
            liste.AddRange(dizi);
            Guncelle(liste);

            ArrayList liste2 = new ArrayList() { 1, 2, 3 };
            liste.AddRange(liste2);
            liste.AddRange(dizi);
            Console.WriteLine(" AddRange(ArrayList)");
            Guncelle(liste);

            //Clear
            //Console.WriteLine("Clear dan sonra");
            //liste.Clear();
            //Guncelle(liste);

            //Contains
            Console.WriteLine("Contains den sonra");
            bool varmi=liste.Contains(3);
            Console.WriteLine($"3 var mı :{varmi}");

            //index of tan sonra
            Console.WriteLine("İndexof dan sonra");
            int bulananIndis=liste.IndexOf(3);
            Console.WriteLine($"3 nerde :{bulananIndis}");

            //insert
            Console.WriteLine("insert 77");
            liste.Insert(bulananIndis, 77);
            Guncelle(liste);

            //setrange
            Console.WriteLine("setrange den sonra");
            liste.SetRange(0, liste2);
            Console.WriteLine("liste2");
            Guncelle(liste2);

            Guncelle(liste);


        }

        static void Guncelle(ArrayList liste)
        {
            Console.WriteLine($"----Güncellem-----");
            Console.WriteLine($"Capacity: {liste.Capacity}");
            Console.WriteLine($"Count: {liste.Count}");

            foreach (var item in liste)
            {
                Console.Write(item + " ");

            }
            Console.WriteLine();
        }
    }
}
