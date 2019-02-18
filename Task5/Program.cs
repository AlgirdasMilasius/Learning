using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 5.	Parašykite programą, kuri suskaičiuotų, kiek knygų k vidutiniškai per metus perskaito vienas mokyklos bibliotekos lankytojas.
/// Žinomas vidutiniškai per mėnesį perskaitytų knygų skaičius v ir vidutiniškai per metus apsilankiųsių bibliotekoje skaičius n. 
/// </summary>

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insert the amount of books read in a month");
            var v = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert the amount of visitors per year");
            var n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("In average one visitor reads {0} books per year", Math.Round((double)v * 12 / n,2));

            

        }
    }
}
