using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05.Godzilla_vs.Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int people = int.Parse(Console.ReadLine());
            double clothing = double.Parse(Console.ReadLine());

            double decor = budget * 10 / 100;
            clothing = clothing * people;

            if(people > 150)
            {
                clothing = clothing - clothing * 10 / 100;
            }

            double money = decor + clothing;

            if (money <= budget)
            {
                Console.WriteLine($"Action!");
                double enough = budget - money;
                Console.WriteLine($"Wingard starts filming with {enough:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money!");
                double notEnough = money - budget;
                Console.WriteLine($"Wingard needs {notEnough:f2} leva more.");
            }
        }
    }
}
