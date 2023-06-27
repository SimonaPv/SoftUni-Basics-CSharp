using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch___case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string weather = Console.ReadLine();

            switch (weather)
            {
                case "windy":
                    Console.WriteLine("Take a jacket");
                    break;
                case "sunny":
                    Console.WriteLine("Take shorts");
                    break;
                case "rainy":
                    Console.WriteLine("Take an umbrella");
                    break;
                default:
                    Console.WriteLine("Invalid weather");
                    break;
            }
        }
    }
}
