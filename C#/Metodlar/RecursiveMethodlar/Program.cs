using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursiveMethodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 den N'ye kadar olan sayilarin toplami
            #region Soru1
            int toplam = Topla(4);
            #endregion

            //N!
            #region Soru2
            int carpim = FaktoriyelHesapla(5);
            #endregion

            //Fibonachi
            int fib = FibBul(6);

            //1 den Nye kadar Fib
            #region Soru4
            int fibtoplam2 = NFibToplamBul(5);
            #endregion
          
        }

        //soru4
        private static int NFibToplamBul(int n)
        {
            if (n==0)
            {
                return 0;
            }
            return FibBul(n) + NFibToplamBul(n-1);
        }

        static int FibBul(int n)
        {
            if(n==1 ||n==2)
            {
                return n-1;
            }
            return FibBul(n-1)+FibBul(n-2);
        }

        static int FaktoriyelHesapla(int n)
        {
            if(n==1)
            {
                return 1;
            }
            return n * FaktoriyelHesapla(n - 1);
        }

        //Soru 2

        //Soru 1
        static int Topla(int n)
        {
            if (n==0)
            {
                return 0;
            }
            return n + Topla(n-1);
        }

    }
}
