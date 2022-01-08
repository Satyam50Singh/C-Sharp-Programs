using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintW
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                    {
                        Console.Write("\\");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                for (int j = 4; j < 7; j++)
                {
                    if (i > 0)
                    {
                        if (i + j == 7)
                        {
                            Console.Write("/");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
