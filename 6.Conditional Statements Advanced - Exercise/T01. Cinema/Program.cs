using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double money = 0.0;

            if (type == "Premiere")
            {
                money = r * c * 12;
                Console.WriteLine($"{money:f2} leva");
            }
            else if (type == "Normal")
            {
                money = r * c * 7.5;
                Console.WriteLine($"{money:f2} leva");
            }
            else if (type == "Discount")
            {
                money = r * c * 5;
                Console.WriteLine($"{money:f2} leva");
            }
        }
    }
}
