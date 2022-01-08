using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IndexerSimpleExample
{
    class Indexes {
        public string this[string name]
        {
            get
            {
                Console.WriteLine("Get Before Return : " + name);
                return "Hello, " + name;
            }
            set {
                Console.WriteLine("Set Before Return : " + name);
                name = value;
                Console.WriteLine("Set Before Return : " + name);
            }
        }   
    }
    class Program
    {
        static void Main(string[] args)
        {
            Indexes I1 = new Indexes();
            Console.WriteLine(I1["Satyam Singh"]);
            Console.WriteLine(I1["Anuj Panthri"]);
            Console.ReadKey();
        }
    }
}
