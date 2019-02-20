using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 6.	Parašykite programą, kuri suskaičiuotų,
/// kiek vidutiniškai keleivių k važiuoja į Vilnių viename traukinio vagone,
/// jei žinomas traukinio keleivių skaičius n, 
/// keleivių, vykstančių ne į Vilnių skaičius m
/// ir vagonų skaičius v. 
/// Pvz.: n=100, m=20 ir v=4, tai k=20.
/// 
/// </summary>

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Insert the number of total pasengers ," +
                " number of passengers to other destinations and "+
                " and the number or carts");
            int passengersTotal = Convert.ToInt32(Console.ReadLine());
            int passengersToOther = Convert.ToInt32(Console.ReadLine());
            int carts = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("On average {0} passengers are going to vilnius in each cart", (passengersTotal-passengersToOther)/carts );

        }
    }
}
