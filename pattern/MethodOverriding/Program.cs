using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MethodOverriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Father F1 = new Son();
            F1.Property();
            Son S1 = new Son();
            S1.Property();

            //Son S1 = new Father();
            //S1.Property();
            
            Console.ReadLine();
        }
    }
}

class Father {
    public virtual void Property() {
        Console.WriteLine("Father's Property");
    }
}

class Son : Father {
    // Method overriding
    public override void Property()
    {
        Console.WriteLine("Son's Property");
    }
}