using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program4_SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            const int range = 10;
            int[] arr = new int[range] { 23, 45, 67, 8, -9, 76, 88, 12, 7, 2 };
            Console.WriteLine("\nArray : ");
            Sort.show(arr, range);
            for (int i = 0; i < range-1; i++)
            {
                for (int j = 0; j < (range - i - 1); j++)
                {
                    if (arr[j] > arr[j + 1]) {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            Console.WriteLine("\nSorted Array : ");
            Sort.show(arr, range);
            Console.ReadKey();
        }
    }
    class Sort { 
        public static void show(int[] arr,int range) {
            for (int i = 0; i < range; i++) {
                Console.Write(arr[i] + "  ");
            }
        }

    }
}
