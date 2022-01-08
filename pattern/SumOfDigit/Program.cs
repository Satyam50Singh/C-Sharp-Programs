using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOfDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = Int32.Parse(Console.ReadLine());
            int temp = num;
            int sum = 0;
            while (temp > 0)
            {
                sum += temp % 10;
                temp /= 10;
            }
            Console.WriteLine("Sum of digit is :" + sum);
            Console.ReadLine();

        }
    }
}
