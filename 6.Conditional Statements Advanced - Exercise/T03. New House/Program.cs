using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03.New_House
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int howMuch = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double money = 0;

            switch (flowers)
            {
                case "Roses":
                    if (howMuch > 80)
                    {
                        money = howMuch * 5 - howMuch * 5 * 0.1;
                    }
                    else
                    {
                        money = howMuch * 5.0;
                    }
                    
                    break;
             
                case "Dahlias":
                    if (howMuch > 90)
                    {
                        money = howMuch * 3.8 - howMuch * 3.8 * 0.15;
                    }
                    else
                    {
                        money = howMuch * 3.8;
                    }
                    break;
                
                case "Tulips":
                    if (howMuch > 80)
                    {
                        money = howMuch * 2.8 - howMuch * 2.8 * 0.15;
                    }
                    else
                    {
                        money = howMuch * 2.8;
                    }
                    break;
                
                case "Narcissus":
                    if (howMuch < 120)
                    {
                        money = howMuch * 3.0 + howMuch * 3 * 0.15;
                    }
                    else
                    {
                        money = howMuch * 3.0;
                    }
                    break;
               
                case "Gladiolus":
                    if (howMuch < 80)
                    {
                        money = howMuch * 2.5 + howMuch * 2.5 * 0.2;
                    }
                    else
                    {
                        money = howMuch * 2.5;
                    }
                    break;
            }

            if (money <= budget)
            {
                double youHave = budget - money;
                Console.WriteLine($"Hey, you have a great garden with {howMuch} {flowers} and {youHave:f2} leva left.");
            }
            else
            {
                double youNeed = money - budget;
                Console.WriteLine($"Not enough money, you need {youNeed:f2} leva more.");
            }
        }
    }
}