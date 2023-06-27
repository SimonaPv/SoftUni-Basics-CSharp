using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03.Sum_Prime_Non_Prime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int prime = 0;
            int nonprime = 0;
            string command;

            while ((command = Console.ReadLine()) != "stop")
            {
                int currNum = int.Parse(command);
                if (currNum < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue; // wurti ot nachalo while loopa
                }
                else if (currNum == 0)
                {
                    nonprime += currNum;
                    continue;
                }
                bool isPrime = true;
                for (int div = 2; div < currNum; div++)
                {
                    if (currNum % div == 0)
                    {
                        isPrime = false;
                        break;
                    }                  
                }
                if (isPrime)
                {
                    prime += currNum;
                }
                else
                {
                    nonprime += currNum;
                }        
            }
            Console.WriteLine($"Sum of all prime numbers is: {prime}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonprime}");
        }
    }
}
