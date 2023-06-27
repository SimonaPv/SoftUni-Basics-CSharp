using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T06.Unique_PIN_Codes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine()); 
            int thirdNumber = int.Parse(Console.ReadLine());

            for (int s = 2; s <= firstNumber; s+=2)
            {
                for (int a = 2; a <= secondNumber; a++)
                {
                    for (int p = 2; p <= thirdNumber; p+=2)
                    {
                        if (a == 2 || a == 3 || a == 5 || a == 7)
                        {
                            Console.WriteLine(s + " " + a + " " + p);
                        }
                    }
                }
            }
        }
    }
}
