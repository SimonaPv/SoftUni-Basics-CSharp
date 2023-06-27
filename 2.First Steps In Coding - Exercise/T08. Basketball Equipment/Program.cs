using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T08.Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());
            double sneakers = tax - (0.4 * tax);
            double outfit = sneakers - (0.2 * sneakers);
            double ball = 0.25 * outfit;
            double accessories = 0.20 * ball;
            double sum = tax + sneakers + outfit + ball + accessories;
            Console.WriteLine(sum);
        }
    }
}
