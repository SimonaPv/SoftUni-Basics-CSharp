using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T07.Hotel_Room
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int sleepovers = int.Parse(Console.ReadLine());
            double studio = 0;
            double apart = 0;

            if (month == "May" || month == "October")
            {
                studio = sleepovers * 50;
                apart = sleepovers * 65;
                if (sleepovers > 7 && sleepovers < 14)
                {
                    studio = studio - studio * 0.05;
                }
                else if (sleepovers > 14)
                {
                    studio = studio - studio * 0.3;
                    apart = apart - apart * 0.1;
                }
            }

            else if (month == "June" || month == "September")
            {
                studio = sleepovers * 75.2;
                apart = sleepovers * 68.7;
                if (sleepovers > 14)
                {
                    studio = studio - studio * 0.2;
                    apart = apart - apart * 0.1;
                }
            }

            else if (month == "July" || month == "August")
            {
                studio = sleepovers * 76;
                apart = sleepovers * 77;
                if (sleepovers > 14)
                {
                    apart = apart - apart * 0.1;
                }
            }
            Console.WriteLine($"Apartment: {apart:f2} lv.");
            Console.WriteLine($"Studio: {studio:f2} lv.");
        }
    }
}
