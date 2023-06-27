using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03.Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depSum = double.Parse(Console.ReadLine());
            int period = int.Parse(Console.ReadLine());
            double increase = double.Parse(Console.ReadLine());
            double sum = depSum + period * ((depSum * (increase / 100)) / 12);
            Console.WriteLine(sum);
        }
    }
}
