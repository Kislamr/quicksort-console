using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 44, 2, 2, 35, 4, 4, 6, 8, 0, 66, 177, 1, 0 };

            quicksort.printArray(myArray);
            
            quicksort.sort(myArray);
            
            quicksort.printArray(myArray);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
