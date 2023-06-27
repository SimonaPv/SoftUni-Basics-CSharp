using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04.Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vacantion = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());  
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            double price = puzzles * 2.6 + dolls * 3 + bears * 4.1 + minions * 8.2 + trucks * 2;
            int count = puzzles + dolls + bears + minions + trucks;
            if (count >= 50)
            {
                price = price - price * 0.25;
            }
            price = price - price * 0.1;
            double notEnough = vacantion - price;
            double enough = price - vacantion;
            if (vacantion <= price)
            {
                Console.WriteLine($"Yes! {enough:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {notEnough:f2} lv needed.");
            }
        }
    }
}
