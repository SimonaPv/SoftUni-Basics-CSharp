using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04.Computer_Firm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double seilings = 0;
            double all = 0;
            double reit = 0;

            for (int i = 0; i < n; i++)
            {
                int possible = int.Parse(Console.ReadLine());
                int reiting = possible % 10;
                int possSeil = possible / 10;
                
                if (reiting == 2)
                {
                    reit = 2 + reit;
                    seilings = 0;
                }
                else if (reiting == 3)
                {
                    reit = 3 + reit;
                    seilings = possSeil * 50 / 100;
                }
                else if (reiting == 4)
                {
                    reit = 4 + reit;
                    seilings = possSeil * 70 / 100;
                }
                else if (reiting == 5)
                {
                    reit = 5+ reit;
                    seilings = possSeil * 85 / 100;
                }
                else if (reiting == 6)
                {
                    reit = 6 + reit;
                    seilings = possSeil * 100 / 100;
                }
                all += seilings;
            }

            Console.WriteLine($"{all:f2}");
            double aver = reit / n;
            Console.WriteLine($"{aver:f2}");
        }
    }
}
