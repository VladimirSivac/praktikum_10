using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praktikum_10
{
    /// <summary>
    /// Program
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Main
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = Input();
            Console.Write("b = ");
            int b = Input();
            Console.WriteLine($"Максимальное число - {Max(a, b)}");
            Console.ReadLine();
        }
        /// <summary>
        /// Input
        /// </summary>
        /// <returns>a</returns>
        static int Input()
        { 
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
        /// <summary>
        /// MaxValue
        /// </summary>
        /// <param name="a">int a</param>
        /// <param name="b">int b</param>
        /// <returns>max-param</returns>
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
