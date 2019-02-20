using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Didžiojoje Britanijoje skysčiai matuojami galonais ir bušeliais.
/// 1 galonas – 4,54069 litro, 8 galonai sudaro bušelį.
/// Sudėkite du skysčio kiekius, išreikštus angliškais vienetais ir bušelius bei galonus pakeiskite litrais
/// </summary>

namespace Task14
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insert the first container (galons and bushels): ");
            var g1 = Convert.ToDouble(Console.ReadLine());
            var b1 = Convert.ToDouble(Console.ReadLine());
            var liters1 = g1 * 4.54069 + b1 * 4.54069 * 8;

            Console.WriteLine("Insert the second container (galons and bushels): ");
            var g2 = Convert.ToDouble(Console.ReadLine());
            var b2 = Convert.ToDouble(Console.ReadLine());
            var liters2 = g2 * 4.54069 + b2 * 4.54069 * 8;

            Console.WriteLine("Total liters: {0}", liters1+liters2);




        }
    }
}
