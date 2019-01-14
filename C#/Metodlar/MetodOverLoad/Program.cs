using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodOverLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = Topla(1,2);//=> 1 e gider
            byte a = 4;
            byte b = 3;

            int toplam2 = Topla(a,b);
            string toplam3= Topla('a', 'b');
            // String substring metodunu kendimiz yazalım... 
            #region Soru2
            string metin = "deneme";
            string metin1 = Substring(metin,2);
            string metin2 = Substring(metin, 2,2);
            #endregion

        }
        //Soru2
        private static string Substring(string metin, int index)
        {
            string s = "";
            for (int i = index; i < metin.Length; i++)
            {
                s = s + metin[i];
            }
            return s;
        }
        //Soru2
        private static string Substring(string metin, int index,int length)
        {
            string s = "";
            for (int i = index; i < index+length; i++)
            {
                s = s + metin[i];
            }
            return s;
        }

        //1
        static int Topla(int x, int y)
        {
            return x + y;
        }

        static int Topla(int x, int y, int z = 3)
        {
            return x + y + z;
        }

        static int Topla(byte x, byte y)
        {
            return x + y;
        }

        static string Topla(char x, char y)
        {
            return x.ToString() + y;
        }

    }
}
