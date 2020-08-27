using System;

namespace SololearnCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int myAge;
            myAge = 18;
            int x = 42;
            double pi = 3.14;
            char y = 'Z';
            bool isOnline = true;
            string firstName = "David";

            Console.WriteLine(x);

            string yourName;
            Console.WriteLine("What is your name?");
            yourName = Console.ReadLine();
            Console.WriteLine($"Hello {yourName}.");

            //Comment

            var num = 42;

            const double Pi = 3.14;

            int t = 8;
            int d = 15;
            Console.WriteLine(d - t);
            //Outputs 7

            int v = 42;
            v + 2;
            v -= 6;
        }
    }
}
