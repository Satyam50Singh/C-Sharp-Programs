using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int s = 2;
            int e = 200;
            int c = 0;
            Console.WriteLine("Prime Number : ");
            for (int i = s; i <= e; i++) {
                c = 0;
                for (int j = 1; j <= i; j++) {
                    if (i % j == 0) {
                        c++;
                    }                
                }
                if (c == 2) {
                    Console.Write(i+ "  ");
                }
            }
            Console.ReadKey();
        }
    }
}
