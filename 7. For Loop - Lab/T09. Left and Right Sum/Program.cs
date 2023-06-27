using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T09.Left_and_Right_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int left = 0;
            int right = 0;

            for (int i = 0; i < 2 * n; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                if (i < n)
                {
                    left += nums;
                }
                else
                {
                    right += nums; 
                }
            }
            if (left == right)
            {
                Console.WriteLine($"Yes, sum = {left}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(left - right)}");
            }
        }
    }
}
