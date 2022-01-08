using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < num; i++) {
                for (int j = 0; j <= i; j++) {
                    Console.Write("*");                
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
