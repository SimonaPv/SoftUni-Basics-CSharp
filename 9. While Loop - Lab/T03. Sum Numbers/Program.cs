
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03.Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int ssum = 0;
            while (ssum < sum)
            {
                int number = int.Parse(Console.ReadLine());
                ssum += number;
            }
            Console.WriteLine(ssum);
        }
    }
}
