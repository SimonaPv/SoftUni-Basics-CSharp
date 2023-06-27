using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            double money = 0.0;
            string place = "";
            string hotel = "";

            if (budget <= 100)
            {
                place = "Bulgaria";

                if (season == "summer")
                {
                    hotel = "Camp";
                    money = budget - budget * 0.7;
                }
                else
                {
                    hotel = "Hotel";
                    money = budget - budget * 0.3;
                }
            }

            else if (budget <= 1000)
            {
                place = "Balkans";

                if (season == "summer")
                {
                    hotel = "Camp";
                    money = budget - budget * 0.6;
                }
                else
                {
                    hotel = "Hotel";
                    money = budget - budget * 0.2;
                }
            }
            if (budget > 1000)
            {
                place = "Europe";
                hotel = "Hotel";
                money = budget - budget * 0.1;
            }
            Console.WriteLine($"Somewhere in {place}");
            Console.WriteLine($"{hotel} - {money:f2}");   
        }
    }
}
