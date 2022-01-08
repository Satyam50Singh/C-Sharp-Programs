using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program3_PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1, range = 10000;
            int n = 0;
            for (int i = start; i <= range; i++) {
                n = 0;
                for (int j = 1 ; j<=(i/2); j++)
                {
                    if (i % j == 0) {
                        n = n + j;
                    }
                }
                if (n == i)
                {
                   Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
