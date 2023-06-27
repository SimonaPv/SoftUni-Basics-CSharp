using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T06.Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int max = int.MinValue;

            while (input != "Stop")
            {
                int number = int.Parse(input);

                if (number < max)
                {
                    max = number;
                }
                input = Console.ReadLine(); 
            }
            Console.WriteLine(max);
        }
    }
}
