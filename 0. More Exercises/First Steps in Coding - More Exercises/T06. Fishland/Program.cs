using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T06.Fishland
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sumSkum = double.Parse(Console.ReadLine());
            double sumCaca = double.Parse(Console.ReadLine());
            double pala = double.Parse(Console.ReadLine());
            double safrid = double.Parse(Console.ReadLine());
            int midii = int.Parse(Console.ReadLine());

            double kgPala = sumSkum + sumSkum * 0.6;
            double kgSafrid = sumCaca + sumCaca * 0.8;

            pala = pala * kgPala;
            safrid = safrid * kgSafrid;
            double midi = midii * 7.5;

            double sum = pala + safrid + midi;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
