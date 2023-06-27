using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05.Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int first = 1; first <= 9; first++)
            {
                for (int second = 1; second <= 9; second++)
                {
                    for (int third = 1; third <= 9; third++)
                    {
                        for (int fourth = 1; fourth <= 9; fourth++)
                        {
                           bool isSpecial = n % first == 0 && n % second == 0 && n % third == 0 && n % fourth == 0; 
                            if (isSpecial)
                            {
                                Console.Write($"{first}{second}{third}{fourth} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
