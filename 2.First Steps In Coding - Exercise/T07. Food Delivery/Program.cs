using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T07.Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegan = int.Parse(Console.ReadLine());
            double food = chicken * 10.35 + fish * 12.40 + vegan * 8.15;
            double desert = food * 20 / 100;
            double sum = food + desert + 2.5;
            Console.WriteLine(sum);
        }
    }
}
