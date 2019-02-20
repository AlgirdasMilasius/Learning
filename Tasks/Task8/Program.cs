using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 8.	Senį besmegenį sudaro trys sniego rutuliai.
/// Popieriuje jie atrodo kaip skrituliai. 
/// Mažiausio skritulio spindulys r.
/// Sudarykite programą, kuri apskaičiuotų kiekvieno skritulio plotą,
/// jei kitų apskritimų spinduliai 2 kartus didesni už pries tai esantį.
/// Pasitikrinkite: r=1, tai skritulių plotai 3.14, 12.56 ir 50.24
/// </summary>

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            var pi = 3.14;
            Console.WriteLine("Insert the smallest R");
            var r = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 3; i++)
            {
                double area = pi * r*r;
                Console.Write("area {1}: {0} ", area, i);
                r = r * 2;
            }

        }
    }
}
