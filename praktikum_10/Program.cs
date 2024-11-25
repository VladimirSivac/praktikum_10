using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = Input();
            Console.Write("b = ");
            int b = Input();
            Console.Write("c = ");
            int c = Input();
            Console.Write("d = ");
            int d = Input();
            int s = Max(a, b) + Max(c, d);
            Console.Write($"s = {Max(a, b)} + {Max(c, d)} = {s}");
            Console.ReadLine();
        }
        static int Input()
        { 
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
        static int Max(int a, int b)
        { 
            if (a > b)
            { 
                return a;
            } 
            else
            { 
                return b; 
            } 
        }
    }
}
