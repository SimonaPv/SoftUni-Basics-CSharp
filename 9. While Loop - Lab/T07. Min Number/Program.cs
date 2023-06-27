using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T07.Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int min = int.MaxValue;

            while (input != "Stop")
            {
                int number = int.Parse(input);

                if (number < min)
                {
                    min = number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(min);
        }
    }
}
