using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FindSmallAndGreatest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of n : ");
            int n = Int32.Parse(Console.ReadLine());

            int[] a = new int[n];
            Console.WriteLine("Enter " + n + " Elements : ");
            for (int i = 0; i < n; i++) {
                a[i] = Int32.Parse(Console.ReadLine());
            }
            int max = a[0];
            int min = a[0];
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max) {
                    max = a[i];
                }
                if (a[i] < min) {
                    min = a[i];
                }
            }
            Console.WriteLine("Smallest is :" + min + "\nLargest is : " + max);
            Console.ReadLine();
        }
    }
}
