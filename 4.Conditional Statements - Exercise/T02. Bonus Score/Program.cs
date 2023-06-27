using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double points = int.Parse(Console.ReadLine());
            double bonus = 0.0;

            if (points <= 100)
            {
                bonus = 5;
            }
            else if (points > 100 && points < 1000)
            {
                bonus = points * 20 / 100;
            }
            else
            {
                bonus =  points * 10 / 100;
            }
            if (points % 2 == 0)
            {
                bonus += 1;
            }
            else if (points % 10 == 5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(points + bonus);
        }
    }
}
