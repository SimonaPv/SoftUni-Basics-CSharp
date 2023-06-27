using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T10.Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int even = 0;
            int odd = 0;    

            for (int i = 1; i <= n; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    even += nums;
                }
                else
                {
                    odd += nums;
                }
            }
            if (even == odd)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {even}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(even - odd)}");
            }
        }
    }
}
