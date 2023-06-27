using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T08.Cinema_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string day = Console.ReadLine();
            int money = 0;
            
            switch (day)
            {
                case "Monday":
                    money = 12;
                    Console.WriteLine(money);
                    break;
                case "Tuesday":
                    money = 12;
                    Console.WriteLine(money);
                    break;
                case "Wednesday":
                     money = 14;
                    Console.WriteLine(money);
                    break;
                case "Thursday":
                    money = 14;
                    Console.WriteLine(money);
                    break;
                case "Friday":
                    money = 12;
                    Console.WriteLine(money);
                    break;
                case "Saturday":
                    money = 16;
                    Console.WriteLine(money);
                    break;
                case "Sunday":
                    money = 16;
                    Console.WriteLine(money);
                    break;
            }
        }
    }
}
