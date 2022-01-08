using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WIPRO2021
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for(int i=0; i<n; i++){
                arr[i]=Int32.Parse(Console.ReadLine());
                //Console.WriteLine(arr[i]);
            }
            int maxfreq = 0, minfreq = 0, MRE = 0, LRE = 0;
            int freq = 0;
            for (int i = 0; i < n; i++ ) {
                int temp = arr[i];
                freq = 1;
                for (int j = i + 1; j < n; j++) {
                    if(temp == arr[j]){
                        freq++;
                    }                
                }
                if (i == 0) {
                    MRE = LRE = arr[i];
                    minfreq = maxfreq = freq;
                }
                if (maxfreq < freq) {
                    maxfreq = freq;
                    MRE = arr[i];
                }
                if (minfreq > freq) {
                    minfreq = freq;
                    LRE = arr[i];
                }
            }
            if (MRE > LRE) {
                Console.WriteLine("rEQ : " + (maxfreq - minfreq));
            }
            Console.WriteLine(maxfreq + "  "  + minfreq+ "  " + MRE+ " " +LRE);
            Console.ReadLine();

        }
    }
}
