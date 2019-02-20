using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 7.	Parašykite programą, kuri suskaičiuotų stačiakampio, 
/// kurio viršutinio kairiojo taško (x1;y1) ir apatino dešiniojo taško (x2;y2) coordinates sveikieji skaičiai,
/// plotą s ir perimetrą p.
/// Stačiakampio kraštinės lygiagrečios koordinačių ašims. 
/// Pvz.: x1=0, y1=5, x2=4, y2=0, tai s=20 ir p=18.
/// </summary>

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert cordinates for point 1 (x and y)");
            var x1 = Convert.ToInt32(Console.ReadLine());
            var y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Insert cordinates for point 2 (x and y)");
            var x2 = Convert.ToInt32(Console.ReadLine());
            var y2 = Convert.ToInt32(Console.ReadLine());

            var lenght = Math.Max(x1, x2) - Math.Min(x1, x2);
            var width = Math.Max(y1, y2) - Math.Min(y1, y2);

            Console.WriteLine("Perimeter: {0}, area: {1}", lenght*2+width*2, width*lenght);
        }
    }
}
