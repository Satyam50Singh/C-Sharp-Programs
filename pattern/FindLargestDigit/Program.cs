using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindLargestDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number : ");
            int a = Int32.Parse(Console.ReadLine());
            int temp = a;
            int max = 0;
            while (temp > 0) {
                int digit = temp % 10;
                if (max < digit)
                {
                    max = digit;
                }
                temp /= 10;
            }
            Console.WriteLine("Largest Digit : " + max);
            
            Console.ReadLine();
        }
    }
}
