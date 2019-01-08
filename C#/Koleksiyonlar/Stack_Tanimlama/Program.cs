using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Tanimlama
{
    class Program
    {
        static void Main(string[] args)
        {
            //Yigin Tanimlama
            Stack yigin = new Stack();
            yigin.Push(1);
            yigin.Push(2);
            yigin.Push(3);
            yigin.Push(4);
            //pop
            yigin.Pop();
            yigin.Pop();

            yigin.Push(1);
            yigin.Push(2);
            yigin.Push(3);
            yigin.Push(4);
            //peek
            Console.WriteLine(yigin.Peek());

            //foreach
            foreach (var item in yigin)
            {
                Console.WriteLine(item);
            }

            //toArray
            object [] dizi=yigin.ToArray();

            //clone
            object clone=yigin.Clone();
            Stack yeniYigin = (Stack)clone;

            //contains
            bool iss =yigin.Contains(1);
        }
    }
}
