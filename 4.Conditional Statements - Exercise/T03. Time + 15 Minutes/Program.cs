using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03.Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            mins += 15;
            if (mins >= 60)
            {
                hours++;
                mins -= 60; 
            }
            if (hours >= 24)
            {
                hours -= 24;
            }
            Console.WriteLine($"{hours}:{mins:d2}");
        }
    }
}
