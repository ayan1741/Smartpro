using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpsiyonelParametreliMetodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Durum 
            int toplam1 = Topla(2,3,4);

            //2.Durum
            int toplam2 = Topla(1);

            //3.durun
            int toplam3 = Topla(1);

            //named argument
            int toplam4 = Topla(4, z:5);

            //named argument (değişkenleri sıralı olmaması)
            int toplam5 = Topla(z:7,y:6,x:2);

            //named argument (okunabilirlik)
            string productName="";
            namedArgument(productName ,isValid:true, isPrime:false, isOdd:true);
        }


        static void namedArgument(string productName,bool isValid, bool isPrime, bool isOdd)
        {

        }
        static int Topla(int x,int y=2, int z=3)
        {
            int toplam = x + y + z;

            return toplam;
        }
    }
}
