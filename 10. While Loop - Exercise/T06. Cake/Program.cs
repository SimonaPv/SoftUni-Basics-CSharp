using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int piecesCount = length * width;
            string command;

            while ((command = Console.ReadLine()) != "STOP")
            {
                int pieceTaken = int.Parse(command);
                piecesCount -= pieceTaken;

                if (piecesCount < 0)
                {
                    break;
                }
            }

            if (piecesCount < 0)
            {
                int morePieces = Math.Abs(piecesCount);
                Console.WriteLine($"No more cake left! You need {morePieces} pieces more.");
            }
            else
            {
                Console.WriteLine($"{piecesCount} pieces are left.");
            }
        }
    }
}
