using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т04.Fishing_Boat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int people = int.Parse(Console.ReadLine());
            double money = 0.0;

            if (season == "Spring")
            {
                if (people <= 6)
                {
                    money = 3000 - 3000 * 0.1;
                }
                else if ((people > 7) && (people <= 11))
                {
                    money = 3000 - 3000 * 0.15;
                }
                else
                {
                    money = 3000 - 3000 * 0.25;
                }
                if (people % 2 == 0)
                {
                    money = money - money * 0.05;
                }
            }
            if (season == "Summer")
            {
                if (people <= 6)
                {
                    money = 4200 - 4200 * 0.1;
                }
                else if ((people > 7) && (people <= 11))
                {
                    money = 4200 - 4200 * 0.15;
                }
                else
                {
                    money = 4200 - 4200 * 0.25;
                }
                if (people % 2 == 0)
                {
                    money = money - money * 0.05;
                }
            }
            if (season == "Autumn")
            {
                if (people <= 6)
                {
                    money = 4200 - 4200 * 0.1;
                }
                else if ((people > 7) && (people <= 11))
                {
                    money = 4200 - 4200 * 0.15;
                }
                else
                {
                    money = 4200 - 4200 * 0.25;
                }
            }
            if (season == "Winter")
            {
                if (people <= 6)
                {
                    money = 2600 - 2600 * 0.1;
                }
                else if ((people > 7) && (people <= 11))
                {
                    money = 2600 - 2600 * 0.15;
                }
                else
                {
                    money = 2600 - 2600 * 0.25;
                }
                if (people % 2 == 0)
                {
                    money = money - money * 0.05;
                }
            }
            if (money <= budget)
            {
                double enough = budget - money;
                Console.WriteLine($"Yes! You have {enough:f2} leva left.");
            }
            else
            {
                double notEnough = money - budget;
                Console.WriteLine($"Not enough money! You need {notEnough:f2} leva.");
            }
        }
    }
}
