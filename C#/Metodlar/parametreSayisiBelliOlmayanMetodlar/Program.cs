using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parametreSayisiBelliOlmayanMetodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string toplam=Topla("Merhaba",1,2,3,4,5,6);
        }

        static string Topla(string isim,params int[] sayilar)
        {
            int toplam = 0;
            foreach (var item in sayilar)
            {
                toplam = toplam + item;
            }
            return isim+toplam;
        }
    }
}
