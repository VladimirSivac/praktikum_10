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
            double x = Func(5) + Func(12) + Func(19);
            Console.WriteLine($"x = {x:f2}");
            Console.ReadLine();
        }
        /// <summary>
        /// Function
        /// </summary>
        /// <param name="num">num</param>
        /// <returns>x</returns>
        static double Func(double num)
        {
            double x = (Math.Sqrt(num) + num) / 2;
            return x;
        }
    }
}
