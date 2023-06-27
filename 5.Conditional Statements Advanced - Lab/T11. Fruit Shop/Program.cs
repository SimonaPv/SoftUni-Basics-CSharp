using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T11.Fruit_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            double price = 0.0;

            if ((day == "Saturday")|| (day == "Sunday"))
            {
                if (fruit == "banana")
                {
                    price = 2.7 * amount;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "apple")
                {
                    price = 1.25 * amount;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "orange")
                {
                    price = 0.9 * amount;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.6 * amount;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "kiwi")
                {
                    price = 3.0 * amount;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "pineapple")
                {
                    price = 5.6 * amount;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "grapes")
                {
                    price = 4.2 * amount;
                    Console.WriteLine($"{price:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            
            else if ((day == "Monday") || (day == "Tuesday") || (day == "Wednesday") || (day == "Thursday") || (day == "Friday"))
            {
                if (fruit == "banana")
                {
                    price = 2.5 * amount;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "apple")
                {
                    price = 1.2 * amount;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "orange")
                {
                    price = 0.85 * amount;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    price = 1.45 * amount;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "kiwi")
                {
                    price = 2.7 * amount;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "pineapple")
                {
                    price = 5.5 * amount;
                    Console.WriteLine($"{price:f2}");
                }
                else if (fruit == "grapes")
                {
                    price = 3.85 * amount;
                    Console.WriteLine($"{price:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
