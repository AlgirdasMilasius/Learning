using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 1.	Parašykite programą, kuri apskaičiuotų, kiek popieriaus lapų k reikės norint nukopijuoti konspektą visos klasės mokiniams.
/// Žinoma kad klasėje yra m mokinių o konspektą sudaro n lapų.
/// 
/// Pvz.: m=20, n=10, tai atsakymas 200.
/// 
/// </summary>

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insert the number of pages: ");
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert the number of students: ");
            var m = Convert.ToInt32(Console.ReadLine());

            var k = n * m;

            Console.WriteLine("There are {0} pages and {1} students, in total {2} pages will be used", n, m, k);
        }
    }
}
