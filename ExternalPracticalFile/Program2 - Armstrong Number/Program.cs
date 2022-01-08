using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program2_ArmstrongNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, temp=0;
            int digit = 0;
            Console.WriteLine("Enter a number : ");
            num = Int32.Parse(Console.ReadLine());
            int t = num;
            while (num > 0) {
                digit = num % 10;
                temp = temp + (digit * digit * digit);
                num /= 10;
            }
            if (t == temp)
            {
                Console.WriteLine("Given number is armstrong.");
            }
            else {
                Console.WriteLine("Given number is not armstrong.");
            }
            Console.ReadKey();
        }
    }
}
