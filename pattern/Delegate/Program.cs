using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("Enter two numbers : ");
            x = Int32.Parse(Console.ReadLine());
            y = Int32.Parse(Console.ReadLine());

            BCA obj = new BCA();
            
            // single cast delegate
            MyDelegate m = new MyDelegate(obj.Add);
            int res = m(x, y);
            Console.WriteLine("Addition of two number is :" + res);
            m += new MyDelegate(obj.Mul);
            int res2 = m(x, y);
            Console.WriteLine("Multiplication of two number is :" + res2);
            

            // Multicast Delegate
            MySecondDelegate M = new MySecondDelegate(obj.Addition);
            M(x, y);
            M += new MySecondDelegate(obj.Multiplication);
            M(x, y);
            M -= new MySecondDelegate(obj.Addition);
            M(x, y);
            Console.ReadLine();
        }
    }
}

public delegate int MyDelegate(int x, int y);
public delegate void MySecondDelegate(int x, int y);

class BCA
{
    public int Add(int x, int y)
    {
        return x + y;
    }
    public int Mul(int x, int y)
    {
        return x * y;
    }
    public void Addition(int x, int y)
    {
        Console.WriteLine("Addition is " + (x + y));
    }
    public void Multiplication(int x, int y)
    {
        Console.WriteLine("Multiplication is " + (x * y));
    }
}
