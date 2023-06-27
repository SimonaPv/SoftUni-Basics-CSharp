using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05.Квартално_магазинче
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double amount = double.Parse(Console.ReadLine());
            
            if(city == "Sofia")
            {
                if(product == "coffee")
                {
                    Console.WriteLine(0.5 * amount);
                }
                else if(product == "water")
                {
                    Console.WriteLine(0.8 * amount);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.2 * amount);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.45 * amount);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(1.6 * amount);
                }
            }
            
            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.4 * amount);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.7 * amount);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.15 * amount);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.3 * amount);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(1.5 * amount);
                }
            }
            
            else if (city == "Varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(0.45 * amount);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.7 * amount);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(1.1 * amount);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(1.35 * amount);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(1.55 * amount);
                }
            }
        }
    }
}
