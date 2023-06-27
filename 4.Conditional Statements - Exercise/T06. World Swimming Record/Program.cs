using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T06.World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double timeForOneMeter = double.Parse(Console.ReadLine());

            double ivansTime= meters * timeForOneMeter;
            meters = (Math.Floor(meters / 15)) * 12.5;
            ivansTime = meters + ivansTime;

            if (ivansTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {ivansTime:f2} seconds.");
            }
            else
            {
                double notEnough = ivansTime - record;
                Console.WriteLine($"No, he failed! He was {notEnough:f2} seconds slower.");
            }
        }
    }
}
