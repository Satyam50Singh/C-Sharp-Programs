using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculatorUsingSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculator\n\n1. Press '+' for Add\n2. Press '-' for subtraction\n3. Press '*' for multiplication\n2. Press '/' for division\nEnter your choice : ");
            char ch = Char.Parse(Console.ReadLine());

            Console.WriteLine("Enter two numbers : ");
            int f1, f2;
            f1 = Int32.Parse(Console.ReadLine());
            f2 = Int32.Parse(Console.ReadLine());

            switch (ch) {
                case '+':
                    {
                        Console.WriteLine("Addition : "+ (f1+f2));
                        break;
                    }
                case '-':
                    {
                        Console.WriteLine("Subtraction : "+ (f1 - f2));
                        break;
                    }
                case '*':
                    {
                        Console.WriteLine("Multiplication : " + (f1 * f2));
                        break;
                    }
                case '/':
                    {
                        Console.WriteLine("Division : " + (f1 / f2));
                        break;
                    }
                default: {
                    Console.WriteLine("Wrong choice!");
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
