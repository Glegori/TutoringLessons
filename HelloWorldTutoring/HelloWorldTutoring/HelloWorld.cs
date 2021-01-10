using System;
using System.Collections.Generic;
using System.Threading;

namespace HelloWorldTutoring
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            int numberOfYears = 0;
            Console.WriteLine("Enter your name: ");
            String inputLine = Console.ReadLine();
            Console.WriteLine("Hello " + inputLine);
            Console.Write("Welcome ");
            Console.Write("to ");
            Console.Write("programming! ");
            Console.WriteLine("You have been writing code for " + numberOfYears +  " years");
            Thread.Sleep(5000);
        }
    }
}
