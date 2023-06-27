using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04.Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int combination = 0;
            bool isFound = false;

            for (int i = startNum; i <= endNum; i++)
            {
                for (int j = startNum; j <= endNum; j++)
                {
                    combination++;  
                    if (i+j == magicNum)
                    {
                        isFound = true;
                        Console.WriteLine($"Combination N:{combination} ({i} + {j} = {i+j})");
                    }
                    if (isFound)
                    {
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{combination} combinations - neither equals {magicNum}");
            }
        }
    }
}
