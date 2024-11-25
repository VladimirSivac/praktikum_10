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
            Console.Write("Номер дня: ");
            int day_num = Input();
            Console.WriteLine($"День недели - {Day(day_num)}");
            Console.ReadLine();
        }
        /// <summary>
        /// Input
        /// </summary>
        /// <returns>int a</returns>
        static int Input()
        { 
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
        /// <summary>
        /// Day of the week
        /// </summary>
        /// <param name="day_num">int day_num</param>
        /// <returns>day</returns>
        static string Day(int day_num)
        {
            string day = "";
            switch (day_num)
            {
                case 1: day ="Понедельник"; break;
                case 2: day = "Вторник"; break;
                case 3: day = "Среда"; break;
                case 4: day = "Четверг"; break;
                case 5: day = "Пятница"; break;
                case 6: day = "Суббота"; break;
                case 7: day = "Воскресенье"; break;
            }
            return day;
        }
    }
}
