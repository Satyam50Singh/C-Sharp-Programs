using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SumOfElementsIn1DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5] {12, 3, 7, 8, 5 };

            int sum = 0;
            for (int i = 0; i < 5; i++) {
                sum += a[i];
            }
            Console.WriteLine("Sum is : "+ sum);
            Console.Read();
        }
    }
}
