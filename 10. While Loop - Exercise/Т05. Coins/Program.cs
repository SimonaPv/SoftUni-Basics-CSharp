using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Т05.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            int coins = 0;
            while (sum > 0)
            {
                sum = Math.Round(sum, 2);
                if (sum >= 3)
                {
                    sum -= 2;
                    coins++;
                }
                else if (sum >= 2)
                {
                    sum -= 2;
                    coins++;
                }
                else if (sum >= 1)
                {
                    sum -= 1;
                    coins++;
                }
                else if (sum >= 0.5)
                {
                    sum -= 0.5;
                    coins++;
                }
                else if (sum >= 0.2)
                {
                    sum -= 0.2;
                    coins++;
                }
                else if (sum >= 0.1)
                {
                    sum -= 0.1;
                    coins++;
                }
                else if (sum >= 0.05)
                {
                    sum -= 0.05;
                    coins++;
                }
                else if (sum >= 0.02)
                {
                    sum -= 0.02;
                    coins++;
                }
                else if (sum >= 0.01)
                {
                    sum -= 0.01;
                    coins++;
                }
            }
            Console.WriteLine(coins);
        }
    }
}
