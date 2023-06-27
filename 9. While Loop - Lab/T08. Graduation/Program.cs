using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int schoolClasses = 1;
            double sum = 0;
            int notPassed = 0;
 
            while (schoolClasses <= 12 && notPassed < 2)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4.00)
                {
                    sum += grade;
                    schoolClasses++;
                }
                else
                {
                    notPassed += 1;
                }
            }
 
            if (notPassed < 2)
            {
                double average = sum / 12;
                Console.WriteLine($"{name} graduated. Average grade: {average:F2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {schoolClasses} grade");
            }
        }
    }
}
