using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T09.Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double greening = double.Parse(Console.ReadLine());
            double price = greening * 7.61;
            double dicountPrice = price - price * 0.18;
            double discount = price * 0.18;
            Console.WriteLine($"The final price is: {dicountPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
