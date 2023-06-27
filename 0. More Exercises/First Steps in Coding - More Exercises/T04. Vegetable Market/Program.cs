using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04.Vegetable_Market
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vegetables = double.Parse(Console.ReadLine());
            double fruits = double.Parse(Console.ReadLine());
            int sumVeg = int.Parse(Console.ReadLine());
            int sumFruits = int.Parse(Console.ReadLine());
            vegetables = vegetables * sumVeg;
            fruits = fruits * sumFruits;
            double sum = (vegetables + fruits) / 1.94;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
