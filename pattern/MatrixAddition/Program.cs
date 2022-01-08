using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MatrixAddition
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] m1 = new int[10, 10]; // rectangular array
            int[,] m2 = new int[10, 10];
            int[,] m3 = new int[10, 10];

            Console.WriteLine("Enter first matrix of 3X3 : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m1[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter SECOND matrix of 3X3 : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m2[i, j] = Int32.Parse(Console.ReadLine());
                }
            }

            //            Console.WriteLine("Enter first matrix of 3X3 : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m3[i, j] = m1[i, j] + m2[i, j];
                }
            }

            Console.WriteLine("\nMatrix Addition :");

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(m3[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
