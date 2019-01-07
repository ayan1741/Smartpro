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
            string a = "dlkflsjl";
            char [] dizi=a.ToCharArray();
            var yeni=dizi.Reverse();
            Console.WriteLine(yeni.GetType());
        }
    }
}
