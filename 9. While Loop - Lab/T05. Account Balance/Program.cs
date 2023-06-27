using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05.Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            string input = Console.ReadLine();

            while (input != "NoMoreMoney")
            {
                double number = double.Parse(input);

                if (number < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {number:f2}");
                total += number;
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
