using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T08.Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int time = int.Parse(Console.ReadLine());
            int breaktime = int.Parse(Console.ReadLine());

            double lunch = breaktime / 8.0;
            double sleep = breaktime / 4.0;

            double enough = breaktime - lunch - sleep;

            if (enough >= time)
            {
                double howMuch = Math.Ceiling(enough - time);
                Console.WriteLine($"You have enough time to watch {name} and left with {howMuch} minutes free time.");
            }
            else
            {
                double howMuch = Math.Ceiling(time - enough);
                Console.WriteLine($"You don't have enough time to watch {name}, you need {howMuch} more minutes.");
            }
        }
    }
}
