using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CheckStringAsPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution.StringTesting T1 = new Solution.StringTesting();
            T1.starts();
            Console.ReadLine();
        }
    }
}

// Abstract Class
// Single Inheritance
namespace Solution {
    abstract class Validate
    {
        public string username;
        public string str;
       //constructor
        public Validate()
        {
            Console.Write("Enter your name : ");
            string temp = Console.ReadLine();
            username = temp;
        }
        // Abstract Method
        public abstract void getString();
    }

    class Testing : Validate
    {
        public void WelcomeMsg()
        {
            Console.WriteLine("\nWelcome " + username + " to my program\n");
        }
        public override void getString()
        {
            Console.WriteLine("In this method, we will get our string \n");
            Console.Write("\n\nEnter your password : ");
            string temp = Console.ReadLine();
            str = temp;
        }
        public void validate() {
            Console.WriteLine("\nString is : " + str);
            int size = str.Length;
            if (size > 8)
            {
                Console.WriteLine("Invalid Password! Size Excedded");
            }
            else {
                int AlphaCap = 0;
                int AlphaSmall = 0;
                int numeric = 0; 
                foreach (char s in str) {
//                    Console.WriteLine(s);
                    if (' ' == s || '/' == s)
                    {
                        Console.WriteLine("Invalid Password!");
                        break;
                    }
                    if (s >= 'A' && s <= 'Z')
                    {
                        AlphaCap++;
                    }
                    if (s >= 'a' && s <= 'z')
                    {
                        AlphaSmall++;
                    }
                    if (s >= '0' && s <='9')
                    {
                        numeric++;
                    }
                }
                if (AlphaCap == 0 || AlphaSmall == 0 || numeric == 0)
                {
                    Console.WriteLine("Invalid Password! Enter At least one Small and Capital letter and one numeric character.");
                }
                else {
                    Console.WriteLine("\nValid Password!");                
                }
            }

        }
    }

    class StringTesting : Testing
    {
        public void starts()
        {
            //new Validate();
            WelcomeMsg();
            getString();
            validate();
        }
    }
}
