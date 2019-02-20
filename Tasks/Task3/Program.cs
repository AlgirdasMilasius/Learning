using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 3.	Indėlininkas į banką padėjo suma litų. 
/// Bankas moka 2proc. metinių palūkanų.
/// Sudarykite programą dviejų metų apskaitai skaičiuoti. Ekrane išveskite palūkanas ir turimą indėlį kasmet.
/// </summary>

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insert the deposited amount: ");
            var sum = Convert.ToDouble(Console.ReadLine());
            
            var interest = 1.02;

            for (int i = 1; i <= 2; i++)
            {
                sum = sum * interest;
                Console.WriteLine("After year {0} the total amount will be {1}", i, sum);
            }
        }
    }
}
