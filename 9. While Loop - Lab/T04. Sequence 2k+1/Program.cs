using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04.Sequence_2k_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int k = 1;

            while(k <= number)
            {
                Console.WriteLine(k);
                k = k * 2 + 1;
            }
        }
    }
}
