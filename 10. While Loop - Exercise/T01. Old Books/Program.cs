using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01.Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string searched = Console.ReadLine();
            int books = 0;
            bool isFound = false;
            string currentBook;

            while ((currentBook = Console.ReadLine()) != "No More Books")
            {
                if (currentBook == searched)
                {
                    isFound = true;
                    break;
                }
                books++;
            }

            if (isFound)
            {
                Console.WriteLine($"You checked {books} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {books} books.");
            }
        }
    }
}
