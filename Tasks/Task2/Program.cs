using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 2.	Žinomi kambario matmenys –ilgis ir plotis. 
/// Abu dydžiai sveikieji skaičiai. 
/// 
/// -Reikia apskaičiuoti, kokią pinigų sumą reiks mokėti už plyteles, skirtas kambario grindims kloti,
/// jei plytelių vieno kvadrato kaina yra kaina litų. Plytelių reikia pirkti 5 proc. daugiau galimiems nuostoliams padengti.
/// </summary>

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the dimensions for the rooms");
            int width = Convert.ToInt32(Console.ReadLine());
            int lenght = Convert.ToInt32(Console.ReadLine());

            var size = width * lenght;
            var sizeAdjusted = size * 1.05;

            Console.WriteLine("The needed amount is {0}, or rounded up {1}", sizeAdjusted, Math.Ceiling(sizeAdjusted));

        }
    }
}
