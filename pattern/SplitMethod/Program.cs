using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SplitMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            PythonMethod.getString();
            PythonMethod P1 = new PythonMethod();
            P1.split();
            Console.ReadKey();
        }
    }
}

class PythonMethod
{
    public static string s1;

    // static method
    public static void getString() {
        Console.WriteLine("Enter a string : ");
        s1 = Console.ReadLine();
    }
    public void split() {
        Console.WriteLine("String : " + s1);
        Console.WriteLine();
//        string str[10];
        for (int i = 0; i < s1.Length; i++) {
            if (s1[i] == ' ')
            {
                Console.Write(",");
            }
            else {
                Console.Write(s1[i]);
            }
        }        
    } 
}