using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T08.On_Time_for_the_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourE = int.Parse(Console.ReadLine());
            int minsE = int.Parse(Console.ReadLine());   
            int hourC = int.Parse(Console.ReadLine());  
            int minsC = int.Parse(Console.ReadLine());

            int hourInMinsE = hourE * 60 + minsE;
            int hourInMinsC = hourC * 60 + minsC;

            if (hourInMinsE < hourInMinsC)
            {
                Console.WriteLine("Late");
            }
            else if (hourInMinsE - hourInMinsC > 30)
            {
                Console.WriteLine("Early");
            }
            else
            {
                Console.WriteLine("On time");
            }

            if (hourInMinsC < hourInMinsE)
            {
                if (hourInMinsE - hourInMinsC < 60)
                {
                    int mins = hourInMinsE - hourInMinsC;
                    Console.WriteLine($"{mins} minutes before the start");
                }
                else 
                {                   
                    int hours = (hourInMinsE - hourInMinsC) / 60;
                    int mins = (hourInMinsE - hourInMinsC) % 60;
                    Console.WriteLine($"{hours}:{mins:d2} hours before the start");
                }               
            }
            

            else
            {
                if (hourInMinsC - hourInMinsE < 60)
                {
                    int mins = hourInMinsC - hourInMinsE;
                    Console.WriteLine($"{mins} minutes after the start");
                }               
                else
                {
                    int hours = (hourInMinsC - hourInMinsE) / 60;
                    int mins = (hourInMinsC - hourInMinsE) % 60;
                    Console.WriteLine($"{hours}:{mins:d2} hours after the start");
                }
            }
        }
    }
}
