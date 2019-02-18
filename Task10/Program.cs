using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 10.	Sakoma, jei pro skylę pralenda katino galva, tai pralįs ir kūnas.
/// Parašykite programą, kuri nustatytų, ar katinas pralįs pro kvadrato formos skylę.
/// Pradiniai duomenys –katino galvos spindulys ir skylės kraštinės ilgis.
/// Tarsime, kad katino galva yra skritulio formos.
/// </summary>

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the cat head R and square lenght");
            double catR = Convert.ToDouble(Console.ReadLine());
            double squareLenght = Convert.ToDouble(Console.ReadLine());

            if (catR*2>squareLenght)
            {
                Console.WriteLine("It fits");
            }
            else
            {
                Console.WriteLine("It doesn't fit");
            }

        }
    }
}
