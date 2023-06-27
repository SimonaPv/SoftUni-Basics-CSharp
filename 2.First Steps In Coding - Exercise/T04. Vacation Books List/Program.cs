using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04.Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pagesInBook = int.Parse(Console.ReadLine());
            int forHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int hours = pagesInBook / forHour;
            int hoursADay = hours / days;
            Console.WriteLine(hoursADay);
        }
    }
}
