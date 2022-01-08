using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Table T1 = new Table();
            T1.printTables(5);
            T1.printTables();
            Console.ReadLine();
        }
    }
}

class Table
{
    int n;
    // Constructor
    public Table() {
        n = 10;
    }
    // Method Overloading
    public void printTables(int n) {
        this.n = n;
        Console.WriteLine("Tables upto 1 to " + n);
    }
    // Method
    public void printTables() {
        for (int i = 1; i <= n; i++) {
            for (int j = 1; j <= 10; j++) {
                Console.Write(i + " * " + j + " = " + i*j + "   ");
            }
            Console.WriteLine();
        }
    }
}
