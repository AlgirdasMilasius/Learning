using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Šeima į mėnesį gauna n litų. 
/// 5% išleidžia mokesčiams o likusius pinigus buitinėms reikmėms:
/// 50% maistui, 30% rūbams ir likusius pramogoms. Sudarykite programą šeimos biudžiatui skaičiuoti.
/// 
/// </summary>

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insert income: ");
            double income = Convert.ToDouble(Console.ReadLine());
            double incomeAfterTax = income * 0.95;
            double food = incomeAfterTax * 0.5;
            double clothes = incomeAfterTax * 0.3;
            double fun = incomeAfterTax * (1 - 0.5 - 0.3);

            Console.WriteLine("Taxes: {0} \nFood: {1} \nClothes: {2} \nFun: {3}",
                income-incomeAfterTax, food, clothes, fun);
        }
    }
}
