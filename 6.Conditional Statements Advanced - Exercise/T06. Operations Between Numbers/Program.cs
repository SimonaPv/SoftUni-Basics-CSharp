
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T06.Operations_Between_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char operat = char.Parse(Console.ReadLine());
            double sum = 0;

            if (operat == '+')
            {
                sum = n1 + n2;
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"{n1} + {n2} = {sum} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} + {n2} = {sum} - odd");
                }
            }

            else if (operat == '-')
            {
                sum = n1 - n2;
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"{n1} - {n2} = {sum} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} - {n2} = {sum} - odd");
                }
            }

            else if (operat == '*')
            {
                sum = n1 * n2;
                if (sum % 2 == 0)
                {
                    Console.WriteLine($"{n1} * {n2} = {sum} - even");
                }
                else
                {
                    Console.WriteLine($"{n1} * {n2} = {sum} - odd");
                }
            }

            else if (operat == '/')
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    sum = (double)n1 / n2;
                    Console.WriteLine($"{n1} / {n2} = {sum:f2}");
                }
            }

            else if (operat == '%')
            {
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                else
                {
                    sum = n1 % n2;
                    Console.WriteLine($"{n1} % {n2} = {sum}");
                }
            }
        }
    }
}
