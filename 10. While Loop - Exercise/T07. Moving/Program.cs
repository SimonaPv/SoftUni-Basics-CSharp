using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fat = int.Parse(Console.ReadLine());
            int llong = int.Parse(Console.ReadLine());
            int hight = int.Parse(Console.ReadLine());

            int vApart = fat * llong * hight;

            string count = Console.ReadLine();
            int boxes = 0;

            while (count != "Done")
            {
                boxes += int.Parse(count);

                 if(vApart < boxes)
                {
                    int space = boxes - vApart;
                    Console.WriteLine($"No more free space! You need {space} Cubic meters more.");
                    break;
                }
                 count = Console.ReadLine();    
            }

            if (count == "Done")
            {
                Console.WriteLine($"{vApart - boxes} Cubic meters left.");
            }
        }
    }
}
