using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

struct stud
{
    public string name, address, rollno;
    public int age;
}

namespace StructureOfStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            stud[] s1 = new stud[10];
            s1[0].rollno = "R190529044";
            s1[0].name = "Satyam Singh";
            s1[0].age = 20;
            s1[0].address = "146, Patel Nagar";

            s1[1].rollno = "R190529045";
            s1[1].name = "Anuj panthri";
            s1[1].age = 19;
            s1[1].address = "146, Araha Ghar";

            Console.WriteLine("Rollno" + "       " + "Name" + "         " + "Age" + "     " + "Address\n");
            Console.WriteLine(s1[0].rollno + "  " + s1[0].name + "    " + s1[0].age + "  " + s1[0].address);
            Console.WriteLine(s1[1].rollno + "  " + s1[1].name + "    " + s1[1].age + "  " + s1[1].address);
            
            Console.ReadKey();
        }
    }
}

