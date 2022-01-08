using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Swapping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers : ");
            int f1, f2;
            f1 = Int32.Parse(Console.ReadLine());
            f2 = Int32.Parse(Console.ReadLine());
            // Without Using Third Variable
            f1 = f1 + f2;
            f2 = f1 - f2;
            f1 = f1 - f2;
            Console.WriteLine(f1 + " , " + f2);
            // Without Using Third Variable
            f1 = f1 ^ f2;
            f2 = f1 ^ f2;
            f1 = f1 ^
                f2;
            Console.WriteLine(f1 + " , " + f2);
            Console.ReadKey();
        }
    }
}
