using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 15.	Senovės Anglijoje buvo trys piniginiai matavimo vienetai: svarai, šilingai ir pencai.
/// Vienas svaras – 20 šilingų, šilingas – 12 pencų.
/// Piniginėje yra S-svarų, Sh-šilingų ir P-pencų.
/// Kaip pasikeis piniginės turinys, jei įdėsime vieną pencą?
/// Įvesti reikėtų piniginės turinį svarais, šilingais, pencais. Išvesti pokytį;
/// </summary>

namespace Task15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert the money amouns (pounds, shilings, pens):" );
            int pound = Convert.ToInt32(Console.ReadLine());
            int shiling = Convert.ToInt32(Console.ReadLine());
            int pens = Convert.ToInt32(Console.ReadLine());

            pens++;
            while (pens >= 12)
            {
                shiling++;
                pens = pens- 12;
            }

            while (shiling>=20)
            {
                pound++;
                shiling = shiling - 20;

            }

            int totalAmount = pound * 20 * 12 + shiling * 12 + pens;
            totalAmount = totalAmount + 1;
            Console.WriteLine("If we add 1 more pens, the currency will be: {0} pounds, {1} shilings, {2} pens",
                pound, shiling, pens);

        }
    }
}
