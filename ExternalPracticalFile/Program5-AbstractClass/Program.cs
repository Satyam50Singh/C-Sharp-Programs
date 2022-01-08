//  WAP to implement the concept of abstract class.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program5_AbstractClass
{
    public abstract class University {
        public abstract  void UniversityName(); // non-implemented method
        public void CourseName() { // implemented method
            Console.WriteLine("BCA");
        }
    }

    class Program: University
    {
        public override void UniversityName()
        {
            Console.WriteLine("SGRR-UNIVERSITY");
        } 
        static void Main(string[] args)
        {
            University Uv = new Program(); // reference variable of abstract class
            Uv.UniversityName();
            Uv.CourseName();
            Console.ReadKey();
        }
    }
}
