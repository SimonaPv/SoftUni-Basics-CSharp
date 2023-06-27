using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T02.Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int badGrades = int.Parse(Console.ReadLine());
            int sum = 0;
            int solved = 0;
            int badGrd = 0;
            string lastTask = string.Empty;
            string taskName;

            while ((taskName = Console.ReadLine()) != "Enough")
            {
                int taskGrade = int.Parse(Console.ReadLine());

                if (taskGrade <= 4)
                {
                    badGrd++;
                }
                if (badGrd >= badGrades)
                {
                    break;
                }
                solved++;
                sum += taskGrade;
                lastTask = taskName;
            }

            if (badGrd >= badGrades)
            {
                Console.WriteLine($"You need a break, {badGrd} poor grades.");
            }
            else
            {
                double average = (double)sum / solved;
                Console.WriteLine($"Average score: {average:f2}");
                Console.WriteLine($"Number of problems: {solved}");
                Console.WriteLine($"Last problem: {lastTask}");
            }
        }
    }
}
