using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_Tanımlama
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue kuyruk = new Queue();
            kuyruk.Enqueue(1);
            kuyruk.Enqueue(2);
            kuyruk.Enqueue(3);
            kuyruk.Enqueue(4);
            // kuyruk.Enqueue(501);

            Console.WriteLine($"Count önce {kuyruk.Count}");
            int gelen =(int)kuyruk.Dequeue();
            Console.WriteLine($"Count sonra {kuyruk.Count}");
            // peek 
            Console.WriteLine($"Sıradaki müşteri {kuyruk.Peek()}");

            //Kalan kişi 1.yöntem
            Console.WriteLine($"Kalan müşteri {kuyruk.Count-1}");

            //2.yöntem
            int kisi = 4;
            int sayac = 0;
            foreach (var item in kuyruk)
            {
                if ((int)item==kisi)
                {
                    break;
                }
                sayac++;     
            }
            Console.WriteLine($"Kalan müşteri {sayac}");

            //clone
            object klon=kuyruk.Clone();
            Queue kuyruk2 = (Queue)klon;
            kuyruk2.Dequeue();

            //toarray
            object [] dizi=kuyruk.ToArray();

            



        }
    }
}
