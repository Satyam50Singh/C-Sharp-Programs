using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = Int32.Parse(Console.ReadLine());
            int fact = 1;
            int temp = num;
            while (temp > 1)
            {
                fact = fact*temp;
                temp--;
            }
            Console.WriteLine("Factorial is :" + fact);
            Console.ReadLine();
        }
    }
}
