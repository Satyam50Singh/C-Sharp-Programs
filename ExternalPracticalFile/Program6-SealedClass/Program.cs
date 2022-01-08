using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Program6_SealedClass
{
    public sealed class University // we cannot inherit this class.
    {
        public void UniversityName()
        {
            Console.WriteLine("SGRR-UNIVERSITY");
        }
        public void CourseName()
        {
            Console.WriteLine("BCA");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            University Uv = new University(); 
            Uv.UniversityName();
            Uv.CourseName();
            Console.ReadKey();
        }
    }
}
