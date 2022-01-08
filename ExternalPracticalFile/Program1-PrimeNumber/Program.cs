// WAP TO generate prtime numbers from 1 to 1000
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program1_PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = 1000;
            int flag = 0;
            Console.WriteLine("Prime Number :");
            for (int i = 1; i <= range; i++) {
                flag = 0;
                for (int j = 1; j <= i; j++) {
                    if (i % j == 0) {
                        flag++;
                    }
                }
                if (flag == 2) {
                    Console.Write(" ," + i);
                }
            }
            Console.ReadKey();
        }
    }
}
