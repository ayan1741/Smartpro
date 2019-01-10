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
            string s = "abcd";
            
            char[] dizi = s.ToCharArray();
            string a=String.Concat(dizi);

            int karakter = dizi[0];
            karakter = karakter + 4;
            char sifreli = (char)karakter;
          
        }
        

    }
}
