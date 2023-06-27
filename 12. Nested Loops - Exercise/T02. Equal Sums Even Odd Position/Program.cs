using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.Equal_Sums_Even_Odd_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = start; i <= end; i++)
            {
                string currNum = i.ToString();
                int even = 0;
                int odd = 0;
                for (int j = 0; j < currNum.Length; j++)
                {
                    int currDigit = int.Parse(currNum[j].ToString());
                    if (j % 2 == 0)
                    {
                        even += currDigit;
                    }
                    else
                    {
                        odd += currDigit;
                    }
                }
                if (odd == even)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
