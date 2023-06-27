using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T05.Training_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
			double hight = double.Parse(Console.ReadLine());
			double width = double.Parse(Console.ReadLine());
			if ((3 <= width) && (width <= hight) && (hight <= 100))
			{
				width = width * 100 - 100;
				hight = hight * 100;
				double hight1 = Math.Floor(hight / 120);
				double width1 = Math.Floor(width / 70);
				Console.WriteLine(hight1 * width1 - 3);
			}
    }
}
