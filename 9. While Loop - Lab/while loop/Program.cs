using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 1;
            while (num <= 300)
            {
                Console.WriteLine(num);
                num++;
            }

            int num1 = 1;
            while (true)
            {
                if (num1 == 6)
                {
                    break;//izliza of while cikula
                }
                Console.WriteLine(num1);
                num1++;
            }

            int num2 = 1;
            while (num2 != 6)
            {
                Console.WriteLine(num2);
                num2++;
            }

            int num3 = 1;
            while (num3 <= 15)
            {
                Console.WriteLine(num3);
                num3++;
                if (num3 == 10)
                {
                    continue;
                }
            }

            for (int i = 0; i < 15; i++)
            {
                if (i == 10)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }
    }
}

