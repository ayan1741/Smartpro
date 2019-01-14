using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinifTanimlama
{
    class Program
    {

        static void Main(string[] args)
        {

            Console.Write("Kaç adet ogrenci girmek istiyorsunuz...");
            int sayi = int.Parse(Console.ReadLine());

            ArrayList liste = new ArrayList();
        
            for (int i = 0; i < sayi; i++)
            {
                Student student = new Student();

                Console.Write("{0}. ogrencinin numarası",i+1);
                student.OgrenciID = int.Parse(Console.ReadLine());

                Console.Write("{0}. ogrencinin adi", i + 1);
                student.Ad = Console.ReadLine();

                Console.Write("{0}. ogrencinin soyadi", i + 1);
                student.Soyad = Console.ReadLine();

                Console.Write("{0}. ogrencinin ortalamasi", i + 1);
                student.Ortalama = double.Parse(Console.ReadLine());

                liste.Add(student);
            }
            
            foreach (var item in liste)
            {
                Console.WriteLine(((Student)item).Ad);
                Console.WriteLine(((Student)item).Soyad);
                Console.WriteLine(((Student)item).OgrenciID);
                Console.WriteLine(((Student)item).Ortalama);
                Console.WriteLine("-------------------------------");
            }
            double min = double.MaxValue;
            int sayac = 0;
            int index = 0;
            foreach (var item in liste)
            {
                if(((Student)item).Ortalama<min)
                {
                    min = ((Student)item).Ortalama;
                    index = sayac;
                }
                sayac++;
            }

            //2.yol
            Student enKucukOrtOgr=(Student)liste[index];
            Console.WriteLine(enKucukOrtOgr.Ad);
            Console.WriteLine(enKucukOrtOgr.Soyad);
            Console.WriteLine(enKucukOrtOgr.OgrenciID);
            Console.WriteLine(enKucukOrtOgr.Ortalama);

            Console.WriteLine("Başka Çozum");
            //1.yol
            foreach (var item in liste)
            {
                if (((Student)item).Ortalama ==min)
                {
                    Console.WriteLine(((Student)item).Ad);
                    Console.WriteLine(((Student)item).Soyad);
                    Console.WriteLine(((Student)item).OgrenciID);
                    Console.WriteLine(((Student)item).Ortalama);
                }
            }
            Student yeni = new Student();
            yeni.Ad = enKucukOrtOgr.Ad;
            yeni.Soyad = enKucukOrtOgr.Soyad;
            yeni.OgrenciID = enKucukOrtOgr.OgrenciID;
            yeni.Ortalama = enKucukOrtOgr.Ortalama;

            bool a=liste.Contains(enKucukOrtOgr);
          



        
            
        } 
    }
     

}
