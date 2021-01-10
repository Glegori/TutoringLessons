using System;
using System.Threading;

namespace StringsVsInt
{
    class StringVsInt
    {
        static void Main(string[] args)
        {
            int numberInt = 3;
            string numberString = "3";
            Console.WriteLine("adding int 3 to int 1 is: " + (numberInt + 1) );
            Console.WriteLine("adding string 3 to string 1 is:  " + (numberString + "1"));
            Console.WriteLine("adding string 3 to int 1 is:  " + (numberString + 1));
            Console.WriteLine("you cant multiply a string without doing an operator overload(this comes much later)");
            Console.WriteLine("most interactions with integers are the same except when it becomes a decimal, 3/2 is: " + (numberInt/2));
            Double numberDouble = numberInt/2;
            Console.WriteLine("in the case you need a decimal you use a double, 3.0/2 is: " + numberDouble + "it will default to int if you do it in the command: " + (numberInt/2));
            Thread.Sleep(5000);
        }
    }
}
