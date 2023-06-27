using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05.Excursion_Sale
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sea = int.Parse(Console.ReadLine());
            int mountain = int.Parse(Console.ReadLine());
            double profit = 0;
            string type = Console.ReadLine();

            while (type != "Stop")
            {
                if (sea == 0) 
                {
                    profit += 0;
                }
                else if (mountain == 0)
                {
                    profit += 0;
                }

                if (type == "sea" && sea > 0)
                {
                    profit += 680;
                    sea--;
                }
                else if (type == "mountain" && mountain > 0)
                {
                    profit += 499;
                    mountain--;
                }

                if (sea == 0 && mountain == 0)
                {
                    break;
                }

                type = Console.ReadLine();  
            }

            if (sea == 0 && mountain == 0)
            {
                Console.WriteLine($"Good job! Everything is sold.");
            }
            Console.WriteLine($"Profit: {profit} leva.");
        }
    }
}
