using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 12.	Mokinys pradėjo spręsti namų darbus, 
/// kai elektroninis laikrodis rodė h1 valandų ir min1 minučių, o baigė, kai buvo h2 valandų ir min2 minučių.
/// Parašykite programą, pagal kurią būtų randama, kiek laiko (valandų ir minučių) mokinys sprendė uždavinius.
/// (Laikykite, kad mokinys uždavinius sprendė mažiau kaip parą).
/// </summary>


namespace Task12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inser starting time (h and min)");
            var h1 = Convert.ToInt32(Console.ReadLine());
            var min1 = Convert.ToInt32(Console.ReadLine());

            var totalTime1 = h1 * 60 + min1;

            Console.WriteLine("Inser ending time (h and min)");
            var h2 = Convert.ToInt32(Console.ReadLine());
            var min2 = Convert.ToInt32(Console.ReadLine());
            var totalTime2 = h2 * 60 + min2;

            var totalTimeDifference = totalTime2 - totalTime1;
            if (totalTimeDifference > 0)
            {
                Console.WriteLine("Total time spent: {0} hours and {1} minutes",
                    totalTimeDifference / 60, totalTimeDifference % 60);
            }
            else
            {
                Console.WriteLine("The inserted times were wrong, unless you have inveted time travelling :)");
            }



        }
    }
}
