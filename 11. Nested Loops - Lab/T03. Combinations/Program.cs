using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03.Combinations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int magicNum = int.Parse(Console.ReadLine());
            int combinations = 0;

            for (int x1 = 0; x1 <= magicNum; x1++)
            {
                for (int x2 = 0; x2 <= magicNum; x2++)
                {
                    for (int x3 = 0; x3 <= magicNum; x3++)
                    {
                        if (x1  + x2 + x3 == magicNum)
                        {
                            combinations++;
                        }
                    }
                }
            }
            Console.WriteLine(combinations);    
        }
    }
}
