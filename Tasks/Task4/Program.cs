using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 4.	Laikrodis rodo laiką h, m. 
/// Parašykite programą, kuri apskaičiuotų kiek minučių ir sekundžių prabėgo po vidurnakčio. 
/// Pvz.: h=3 ir m=5, tai m=185, s=11100
/// </summary>


namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert time (h and then m)");
            int hour = Convert.ToInt32(Console.ReadLine());
            int minute = Convert.ToInt32(Console.ReadLine());

            int totalSeconds = hour * 60 * 60 + minute * 60;
            Console.WriteLine("Time passed since midnight: m = {1} or s = {0}", totalSeconds, totalSeconds/60);

        }
    }
}
