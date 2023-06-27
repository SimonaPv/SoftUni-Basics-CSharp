using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T07.Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int video = int.Parse(Console.ReadLine());  
            int proc = int.Parse(Console.ReadLine());   
            int ram = int.Parse(Console.ReadLine());

            double priceVideo = video * 250;
            double priceProc =  proc * priceVideo * 35 / 100;
            double priceRam = ram * priceVideo * 10 / 100;

            double money = priceVideo + priceProc + priceRam;
           
            if (video > proc)
            {
                money = money - money * 15 / 100;
            }

            if (money <= budget)
            {
                double enough = budget - money;
                Console.WriteLine($"You have {enough:f2} leva left!");
            }
            else
            {
                double notEnough = money - budget;
                Console.WriteLine($"Not enough money! You need {notEnough:f2} leva more!");
            }
        }
    }
}
