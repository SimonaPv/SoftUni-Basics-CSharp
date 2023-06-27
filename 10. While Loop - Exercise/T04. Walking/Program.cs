using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04.Walking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string steps = Console.ReadLine();
            int goal = 0;

            do
            {
                if (steps == "Going home")
                {
                    break;
                }
                goal += int.Parse(steps);
                if (goal >= 10000)
                {
                    break;
                }
                steps = Console.ReadLine();
            } while (steps != "Going home");

            if (steps == "Going home")
            {
                int walking = int.Parse(Console.ReadLine());
                goal += walking;
            }

            int difference = goal - 10000;

            if (difference >= 0)
            {
                Console.WriteLine($"Goal reached! Good job!");
                Console.WriteLine($"{difference} steps over the goal!");
            }
            else
            { 
                Console.WriteLine($"{Math.Abs(difference)} more steps to reach goal.");
            }
        }
    }
}


