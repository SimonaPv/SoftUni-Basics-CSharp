using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T04.Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string name;
            double allGrades = 0;
            double names = 0;

            while((name = Console.ReadLine()) != "Finish")
            {
                double gradesSum = 0;
                names++;
                for (int i = 0; i < people; i++)
                {
                    double grades = double.Parse(Console.ReadLine());
                    gradesSum += grades;
                    allGrades += grades;
                }

                double aver = 0;
                aver = gradesSum / people;
                Console.WriteLine($"{name} - {aver:f2}.");
            }

            allGrades = allGrades / (names * people);
            Console.WriteLine($"Student's final assessment is {allGrades:f2}.");
        }
    }
}
