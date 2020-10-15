using System;
using Algoritm;
using ReadAndWriteData;

namespace MyProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Class1 c1 = new Class1();
            Class2 c2 = new Class2();

            Console.WriteLine("add="+c1.Add(2,4)+"\nmultiple="+c2.Multiple(2,4));
        }
    }
}
