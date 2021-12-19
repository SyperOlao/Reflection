using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Closet cl = new Closet("h", 1, 2);
            Console.WriteLine(cl.NumOfShelves);
            Console.WriteLine("Hello World!");
        }
    }
}