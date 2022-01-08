using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of n : ");
            int n = Int32.Parse(Console.ReadLine());

            int[] a = new int[n];
            Console.WriteLine("Enter " + n + " Elements : ");
            for (int i = 0; i < n; i++)
            {
                a[i] = Int32.Parse(Console.ReadLine());
            }
            /*
            for (int i = 0; i < n; i++) {
                for (int j = 0; j <n; j++) {
                    if (a[i] < a[j]) {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }                
                }
            }*/
            // Bubble Sort
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n - i - 1; j++) {
                    if (a[j] > a[j+1])
                    {
                        int temp = a[j];
                        a[j] = a[j+1];
                        a[j+1] = temp;
                    }
                }            
            }
                Console.WriteLine("Sorted array : ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + ", ");                
            }
            Console.ReadLine();
        }
    }
}
