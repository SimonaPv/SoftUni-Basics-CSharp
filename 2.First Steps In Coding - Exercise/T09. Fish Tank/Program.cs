using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T09.Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());
            double water = length * width * hight;
            double liters = water / 1000;
            double waterWithDecor = liters * (1 - procent / 100);
            Console.WriteLine(waterWithDecor);
        }
    }
}
