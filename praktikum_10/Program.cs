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
            double x = Func(5, 7) + Func(12, 8) + Func(19, 2);
            Console.WriteLine($"x = {x:f2}");
            Console.ReadLine();
        }
        /// <summary>
        /// Function
        /// </summary>
        /// <param name="num">num1, num2</param>
        /// <returns>x</returns>
        static double Func(double num1, double num2)
        {
            double x = (Math.Sqrt(num1) + num1) / (Math.Sqrt(num2) + num2);
            return x;
        }
    }
}
