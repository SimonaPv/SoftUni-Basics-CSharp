using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T01.Number_Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int n = int.Parse(Console.ReadLine());
            int cnt = 1;
            bool stop = false;

            for (int rows = 1; rows <= n; rows++)
            {
                for (int cols = 1; cols <= rows; cols++)
                {
                    Console.Write(cnt + " ");
                    cnt++;

                    if (cnt > n)
                    {
                        stop = true;
                        break;
                    }
                }
                if (stop)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
