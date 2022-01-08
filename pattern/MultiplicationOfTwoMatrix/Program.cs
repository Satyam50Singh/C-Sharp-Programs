using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultiplicationOfTwoMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            MatrixMultiplication M1 = new MatrixMultiplication();
            int res = M1.getRowAndColumn();
            if (res == 1) {
                M1.getMatrix();
                System.Console.Clear();
                M1.showMatrix();
                M1.multiplication();
                M1.showResult();
            }
            Console.ReadKey();
        }
    }
    class MatrixMultiplication {
        int[,] m1 ;
        int[,] m2 ;
        int[,] m3 ;
        int r1, c1, r2, c2;

        public int getRowAndColumn()
        {
            Console.WriteLine("Enter the no. of rows and  column of first matrix :");
            r1 = Int32.Parse(Console.ReadLine());
            c1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the no. of rows and  column of second matrix :");
            r2 = Int32.Parse(Console.ReadLine());
            c2 = Int32.Parse(Console.ReadLine());

            if (c2 == r2)
            {
                m1 = new int[r1, c1];
                m2 = new int[r2, c2];
                m3 = new int[r1, c2];
                return 1;
            }
            else {
                Console.WriteLine("Matrix Multiplication Is Not possible with these sizes!!");
                return 0;
            }
            
        }

        public void getMatrix() {
            Console.WriteLine("Enter the elements of first matrix :");
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c1; j++)
                {
                    m1[i, j] = Int32.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter the elements of second matrix :");
            for (int i = 0; i < r2; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    m2[i, j] = Int32.Parse(Console.ReadLine());
                }
            }       
        }
        public void showMatrix() {
            Console.WriteLine("elements of first matrix :");
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c1; j++)
                {
                    Console.Write(m1[i, j] + "   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("elements of second matrix :");
            for (int i = 0; i < r2; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    Console.Write(m2[i, j] + "   ");
                }
                Console.WriteLine();
            }
        }

        public void multiplication() {
            int sum = 0;

            for (int i = 0; i < r1; i++) {
                for (int j = 0; j < c2; j++) {
                    for (int k = 0; k < c1; k++) {
                        sum = sum + m1[i, k] * m2[k, j];        
                    }
                    m3[i, j] = sum;
                    sum = 0;
                }                           
            }        
        }


        public void showResult() {
            Console.WriteLine("elements of second matrix :");
            for (int i = 0; i < r1; i++)
            {
                for (int j = 0; j < c2; j++)
                {
                    Console.Write(m3[i, j] + "   ");
                }
                Console.WriteLine();
            }
        }
    }
}
