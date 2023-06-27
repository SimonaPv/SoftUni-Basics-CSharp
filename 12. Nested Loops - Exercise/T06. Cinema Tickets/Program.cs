using System;

namespace T06.Cinema_Tickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int free = 0;
            int studentCounter = 0;
            int standardCounter = 0;
            int kidsCounter = 0;
            string ticketType = string.Empty;

            double movieTickets = 0;

            while (name != "Finish")
            {
                free = int.Parse(Console.ReadLine());
                movieTickets = 0;

                for (int i = 0; i < free; i++)
                {
                    ticketType = Console.ReadLine();
                    if (ticketType == "End")
                    {
                        break;
                    }
                    else if (ticketType == "standard")
                    {
                        standardCounter++;
                    }
                    else if (ticketType == "student")
                    {
                        studentCounter++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidsCounter++;
                    }
                    movieTickets++;

                }

                Console.WriteLine($"{name} - {movieTickets / free * 100:f2}% full.");
                name = Console.ReadLine();
            }

            double totalTickets = standardCounter + studentCounter + kidsCounter;

            Console.WriteLine($"Total tickets: {totalTickets}");
            Console.WriteLine($"{studentCounter / totalTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{standardCounter / totalTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{kidsCounter / totalTickets * 100:f2}% kids tickets.");
        }
    }
}
 
