using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01.Christmas_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int paper = int.Parse(Console.ReadLine());
            int cloth = int.Parse(Console.ReadLine());  
            double glue = double.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            double pap = paper * 5.8;
            double clot = cloth * 7.2;
            glue = glue * 1.2;

            double all = pap + clot + glue;
            all = all - all * discount / 100;
            Console.WriteLine($"{all:f3}");
        }
    }
}
