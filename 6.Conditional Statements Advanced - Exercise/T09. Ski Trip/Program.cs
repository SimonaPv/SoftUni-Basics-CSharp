using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T09.Ski_Trip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string grade = Console.ReadLine();
            double money = 0;

            if (type == "room for one person")
            {
                money = (days - 1) * 18.0;
            }

            else if (type == "apartment")
            {
                money = (days - 1) * 25.0;
                if (days < 10)
                {
                    money = money - money * 0.3;
                }
                else if (days > 10 && days < 15)
                {
                    money = money - money * 0.35;
                }
                else
                {
                    money = money - money * 0.5;
                }
            }

            else
            {
                money = (days - 1) * 35.0;
                if (days < 10)
                {
                    money = money - money * 0.1;
                }
                else if (days > 10 && days < 15)
                {
                    money = money - money * 0.15;
                }
                else
                {
                    money = money - money * 0.2;
                }
            }

            if (grade == "positive")
            {
                money = money + money * 0.25;
            }
            else
            {
                money = money - money * 0.1;
            }

            Console.WriteLine($"{money:f2}");
        }
    }
}
