using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PerfectNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i < n; i++) {
                if (n % i == 0) {
                    Console.Write(i + "  ");
                    sum += i;
                }
            }
            Console.WriteLine("-----------------------------");
            if (sum == n)
            {
                Console.WriteLine("YES IT'S A PERFECT NUMBER ");
            }
            else {
                Console.WriteLine("NO! IT'S NOT A PERFECT NUMBER ");
            }
            Console.ReadKey();
        }
    }
}
