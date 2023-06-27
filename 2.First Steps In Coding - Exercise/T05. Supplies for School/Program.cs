using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05.Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int liters = int.Parse(Console.ReadLine());
            int discharge = int.Parse(Console.ReadLine());
            double price = pens * 5.8 + markers * 7.2 + liters * 1.2;
            double priceWithDischarge = price - price * discharge / 100;
            Console.WriteLine(priceWithDischarge);
        }
    }
}
