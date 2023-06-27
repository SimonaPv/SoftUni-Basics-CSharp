using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.Deer_of_Santa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int food = int.Parse(Console.ReadLine());
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            double third = double.Parse(Console.ReadLine());

            first = days * first;   
            second = days * second; 
            third = days * third;   

            double all = first + second + third;

            if (all <= food)
            {
                double more = food - all;
                Console.WriteLine($"{Math.Floor(more)} kilos of food left.");
            }
            else
            {
                double less = all - food;
                Console.WriteLine($"{Math.Ceiling(less)} more kilos of food are needed.");
            }
        }
    }
}
