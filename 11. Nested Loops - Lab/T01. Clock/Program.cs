using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01.Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int hours = 0; hours <= 23; hours++)
            {
                for (int mins = 0; mins <= 59; mins++)
                {
                    Console.WriteLine($"{hours}:{mins}");
                }
            }
        }
    }
}
