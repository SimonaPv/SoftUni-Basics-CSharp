using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04.Clever_Lily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washMPrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());
            int toysCollected = 0;
            int savings = 0;

            for (int currAge = 1; currAge <= age; currAge++)
            {
                if (currAge  % 2 != 0)
                {
                    toysCollected++;
                }
                else
                {
                    int moneyPresent = (currAge * 5) - 1;
                    savings += moneyPresent;
                }
            }
            int toySell = toysCollected * toyPrice;
            savings += toySell;

            if (savings >= washMPrice)
            {
                double left = savings - washMPrice;
                Console.WriteLine($"Yes! {left:f2}");
            }
            else
            {
                double notEnough = washMPrice - savings;
                Console.WriteLine($"No! {notEnough:f2}");
            }
        }
    }
}
