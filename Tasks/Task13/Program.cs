using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 13.	Kai kuriose šalyse dar ir dabar vartojama colinė matavimo sistema.
/// 1 colis lygus 25,4 mm, 12 colių sudaro pėdą, o 3 pėdos lygios vienam jardui.
/// Turime dviejų lazdelių ilgius parašytus coline sistema. Koks tu lazdelių sumos ilgis colinėje sistemoje?
/// </summary>

namespace Task13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the first stick size in mm: ");
            int stick1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert the second stick size in mm: ");
            int stick2 = Convert.ToInt32(Console.ReadLine());

            int  totalLenghtInMM = stick1 + stick2;
            int yards = (int)( totalLenghtInMM / (25.4 * 12 * 3));
            int feet = (int)( totalLenghtInMM / (25.4 * 12 ));
            double inches = (double)( totalLenghtInMM / (25.4));

            Console.Write("The lenght is: ");
                Console.Write("{0} yards, ", yards);
                Console.Write("{0} feet, ", feet);
                Console.Write("{0} inches", Math.Round(inches,2));


            Console.WriteLine();

        }
    }
}
