using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T08.Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dogFood = double.Parse(Console.ReadLine());
            double catFood = double.Parse(Console.ReadLine());
            double price = dogFood * 2.5 + catFood * 4.0;
            Console.WriteLine($"{price} lv.");
        }
    }
}
