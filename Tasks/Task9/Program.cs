using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Elektroninis laikrodis rodo laiką: valandas, minutes, sekundes (h, m, s).
/// Sudarykite programą, kuri nustatytų, kiek laiko rodys laikrodis po sekundės
/// </summary>

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now.ToString("hh:mm:ss"));
            Console.WriteLine("After 1 second it will be " + DateTime.Now.AddSeconds(1).ToString("hh:mm:ss"));


        }
    }
}
