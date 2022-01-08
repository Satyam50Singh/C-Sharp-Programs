using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int character=0, digit=0, symbols=0;
            for (int i = 0; i < s.Length; i++) {
                char ch = s[i];
                if ((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z'))
                {
                    character++;
                }
                else if (ch >= '0' && ch <= '9')
                {
                    digit++;
                }
                else {
                    symbols++;
                }
            }
            Console.WriteLine("No. of alphabets : "+ character + "\nNo. of digit : "+digit + "\nNo. of symbols : "+symbols);
            Console.ReadLine();
        }
    }
}
