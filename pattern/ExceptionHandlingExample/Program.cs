using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Enter the value of a & b :");
            try
            {
                a = Int32.Parse(Console.ReadLine());
                b = Int32.Parse(Console.ReadLine());
                c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException e) {
                Console.WriteLine("Error(__) :-" + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :-" + e.Message);
            }
            finally {
                Console.WriteLine("Finally Executed");
            }
            Console.ReadLine();
        }
    }
}
