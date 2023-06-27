using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1NumsCount = 0;
            double p2NumsCount = 0;
            double p3NumsCount = 0;
            double p4NumsCount = 0;
            double p5NumsCount = 0;

            for (int i = 0; i < n; i++)
            {
                int nums = int.Parse(Console.ReadLine());

                if (nums < 200)
                {
                    p1NumsCount++;
                }
                else if (nums <= 399)
                {
                    p2NumsCount++;
                }
                else if (nums <= 599)
                {
                    p3NumsCount++;
                }
                else if (nums <= 799)
                {
                    p4NumsCount++;
                }
                else
                {
                    p5NumsCount++;
                }
            }
            double p1 = p1NumsCount / n * 100;
            double p2 = p2NumsCount / n * 100;
            double p3 = p3NumsCount / n * 100;
            double p4 = p4NumsCount / n * 100;
            double p5 = p5NumsCount / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
