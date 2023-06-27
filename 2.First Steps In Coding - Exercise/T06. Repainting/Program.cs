using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
			int nylon = int.Parse(Console.ReadLine());
			int paint = int.Parse(Console.ReadLine());
			int amount = int.Parse(Console.ReadLine());
			int hours = int.Parse(Console.ReadLine());
			double sumNylon = (nylon + 2) * 1.5;
			double sumPaint = (paint + paint * 0.1) * 14.5;
			double sumAmount = amount * 5.0;
			double sumMaterials = sumNylon + sumPaint + sumAmount + 0.4;
			double sumPeople = (sumMaterials * 0.3) * hours;
			double sum = sumMaterials + sumPeople;
			Console.WriteLine(sum);
		}
    }
}
