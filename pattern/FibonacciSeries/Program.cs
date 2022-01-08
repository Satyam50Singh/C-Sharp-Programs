using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            int first = 0;
            int second = 1;
            int next = first + second;

            Console.Write(first + " " + second);
            for (int i = 2; i < n; i++) {
                Console.Write(" " + next);
                first = second;
                second = next;
                next = first + second;
            }
                Console.ReadKey();
        }
    }
}
