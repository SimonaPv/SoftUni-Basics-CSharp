using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T03.Courier_Express
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kg = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            int km = int.Parse(Console.ReadLine());

            double money = 0;
            double nadcenka = 0;
            double all = 0;
            
            if (type == "standard")
            {
                if (kg < 1)
                {
                    all = km * 0.03;
                }
                else if (kg >= 1 && kg < 10)
                {
                    all = km * 0.05;
                }
                else if (kg >= 10 && kg < 40)
                {
                    all = km * 0.1;
                }
                else if (kg >= 40 && kg < 90)
                {
                    all = km * 0.15;
                }
                else if (kg >= 90 && kg < 150)
                {
                    all = km * 0.2;
                }
            }

            else
            {
                if (kg < 1)
                {
                    money = km * 0.03;
                    nadcenka = 0.03 * 80 / 100;
                    nadcenka = nadcenka * kg;
                    all = km * nadcenka;
                    all = money + all;
                }
                else if (kg >= 1 && kg < 10)
                {
                    money = km * 0.05;
                    nadcenka = 0.05 * 40 / 100;
                    nadcenka = nadcenka * kg;
                    all = km * nadcenka;
                    all = money + all;
                }
                else if (kg >= 10 && kg < 40)
                {
                    money = km * 0.1;
                    nadcenka = 0.1 * 5 / 100;
                    nadcenka = nadcenka * kg;
                    all = km * nadcenka;
                    all = money + all;
                }
                else if (kg >= 40 && kg < 90)
                {
                    money = km * 0.15;
                    nadcenka = 0.15 * 2 / 100;
                    nadcenka = kg * nadcenka;
                    all = km * nadcenka;
                    all = money + all;
                }
                else if (kg >= 90 && kg < 150)
                {
                    money = km * 0.2;
                    nadcenka = 0.2 * 1 / 100;
                    nadcenka = nadcenka * kg;
                    all = km * nadcenka;
                    all = money + all;
                }
            }
            Console.WriteLine($"The delivery of your shipment with weight of {kg:f3} kg. would cost {all:f2} lv.");
        }
    }
}
