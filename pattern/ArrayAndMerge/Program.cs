using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArrayAndMerge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of n for first array : ");
            int n1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of n for second : ");
            int n2 = Int32.Parse(Console.ReadLine());

            int[] a = new int[100];
            int[] b = new int[100];
            Console.WriteLine("Enter " + n1 + " Elements : ");
            for (int i = 0; i < n1; i++)
            {
                a[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter " + n2 + " Elements : ");
            for (int i = 0; i < n2; i++)
            {
                b[i] = Int32.Parse(Console.ReadLine());
            }

            // Bubble Sort
            for (int i = 0; i < n1; i++)
            {
                for (int j = 0; j < n1 - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < n1; i++)
            {
                Console.Write(a[i] + "  ");
            }
            
            // Bubble Sort
            for (int i = 0; i < n2; i++)
            {
                for (int j = 0; j < n2 - i - 1; j++)
                {
                    if (b[j] > b[j + 1])
                    {
                        int temp = b[j];
                        b[j] = b[j + 1];
                        b[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\n--------------------------------");
            for (int i = 0; i < n2; i++)
            {
                Console.Write(b[i] + "  ");
            }
            int[] c = new int[100];
            int x = 0;
            Console.WriteLine("--------------------------------");
            for (int i = 0; i < n1; i++)
            {
                    c[x++] = a[i];
            }
            for (int i = 0; i < n2; i++)
            {
                    c[x++] = b[i];
            }
            // Bubble Sort
            for (int i = 1; i < x; i++)
            {
                for (int j = 0; j < x - i - 1; j++)
                {
                    if (c[j] > c[j + 1])
                    {
                        int temp = c[j];
                        c[j] = c[j + 1];
                        c[j + 1] = temp;
                    }
                }
            }
            for (int i = 1; i < x; i++)
            {
                 Console.Write(c[i] + " ");
            }

                Console.ReadLine();
        }
    }
}
