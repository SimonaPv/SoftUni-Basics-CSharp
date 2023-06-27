using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03.Vacantion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tripCost = double.Parse(Console.ReadLine());
            double savings = double.Parse(Console.ReadLine());
            int totalDays = 0;
            int spendDay = 0;

            while (savings < tripCost)
            {
                string action = Console.ReadLine();
                double actionMoney = double.Parse(Console.ReadLine());

                totalDays++;

                if (action == "spend")
                {
                    savings -= actionMoney;
                    if (savings < 0)
                    {
                        savings = 0;
                    }
                    spendDay++;
                    if (spendDay >= 5)
                    {
                        break;
                    }
                }
                else if (action == "save")
                {
                    savings += actionMoney;
                    spendDay = 0;
                }
            }
            if (spendDay >= 5)
            {
                Console.WriteLine($"You can't save the money.");
                Console.WriteLine($"{totalDays}");
            }
            else
            {
                Console.WriteLine($"You saved the money for {totalDays} days.");
            }
        }
    }
}
