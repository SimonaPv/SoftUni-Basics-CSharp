using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.Summer_Outfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grad = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            string outfit = "";
            string shoes = "";

            if (time == "Morning")
            {
                if (10 <= grad && grad <= 18)
                {
                    outfit = "Sweatshirt";
                    shoes = "Sneakers";
                }
                else if (18 < grad && grad <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (grad >= 25)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
            }

            else if (time == "Afternoon")
            {
                if (10 <= grad && grad <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (18 < grad && grad <= 24)
                {
                    outfit = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (grad >= 25)
                {
                    outfit = "Swim Suit";
                    shoes = "Barefoot";
                }
            }

            else if (time == "Evening")
            {
                if (10 <= grad && grad <= 18)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (18 < grad && grad <= 24)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
                else if (grad >= 25)
                {
                    outfit = "Shirt";
                    shoes = "Moccasins";
                }
            }

            Console.WriteLine($"It's {grad} degrees, get your {outfit} and {shoes}.");
        }
    }
}
