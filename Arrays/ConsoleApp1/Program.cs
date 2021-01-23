using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArrayDemonstration
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = new int[2];
            intArray[0] = 10;
            Console.WriteLine("in our new array our first entry is " + intArray[0] + " our second entry is " + intArray[1] + "\n");
            String[] strArray = {"zeroSpace", "firstSpace", "secondSpace" };
            String[] strArray2 = new String[3] { "zeroSpace", "firstSpace", "secondSpace" };
            Console.Write("even though the contents of the second array are the same it is ");
            Console.Write(strArray == strArray2); 
            Console.WriteLine(" that they equal each other");
            String[] strArray3 = { "zeroSpace", "firstSpace", "secondSpace" };
            Console.Write("even though the third array is a copy of the first one it is ");
            Console.Write(strArray == strArray2);
            Console.WriteLine(" that they equal each other");
            Console.WriteLine("The contents place by place in each array is");
            for (int i=0; i<strArray.Length; i++) {
                Console.WriteLine("The first array contains: " + strArray[i] + " as its " + i +"val" );
                Console.WriteLine("The second array contains: " + strArray2[i] + " as its " + i +"val" );
            }
            Thread.Sleep(5000);
        }
    }
}
