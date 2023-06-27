using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т12.Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sellings = double.Parse(Console.ReadLine());
            double money = 0;

            if (city == "Sofia")
            {
                if (0 <= sellings && sellings <= 500)
                {
                    money = sellings * 5 / 100;
                    Console.WriteLine($"{money:f2}");
                }
                else if (500 <= sellings && sellings <= 1000)
                {
                    money = sellings * 7 / 100;
                    Console.WriteLine($"{money:f2}");
                }
                else if (1000 <= sellings && sellings <= 10000)
                {
                    money = sellings * 8 / 100;
                    Console.WriteLine($"{money:f2}");
                }
                else if (sellings > 10000)
                {
                    money = sellings * 12 / 100;
                    Console.WriteLine($"{money:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }

            else if (city == "Varna")
            {
                if (0 <= sellings && sellings <= 500)
                {
                    money = sellings * 4.5 / 100;
                    Console.WriteLine($"{money:f2}");
                }
                else if (500 <= sellings && sellings <= 1000)
                {
                    money = sellings * 7.5 / 100;
                    Console.WriteLine($"{money:f2}");
                }
                else if (1000 <= sellings && sellings <= 10000)
                {
                    money = sellings * 10 / 100;
                    Console.WriteLine($"{money:f2}");
                }
                else if (sellings > 10000)
                {
                    money = sellings * 13 / 100;
                    Console.WriteLine($"{money:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            
            else if (city == "Plovdiv")
            {
                if (0 <= sellings && sellings <= 500)
                {
                    money = sellings * 5.5 / 100;
                    Console.WriteLine($"{money:f2}");
                }
                else if (500 <= sellings && sellings <= 1000)
                {
                    money = sellings * 8 / 100;
                    Console.WriteLine($"{money:f2}");
                }
                else if (1000 <= sellings && sellings <= 10000)
                {
                    money = sellings * 12 / 100;
                    Console.WriteLine($"{money:f2}");
                }
                else if (sellings > 10000)
                {
                    money = sellings * 14.5 / 100;
                    Console.WriteLine($"{money:f2}");
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
