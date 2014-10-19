using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quicksort
{
    public static class quicksort
    {
        public static int[] x;

        public static void sort(int[] y)
        {
            x = y;
            qSort(0, x.Length - 1);
        }

        // accept an array of numbers
        static void qSort(int Start, int End)
        {
            int i = Start + 1;
            int k = End;

            if (End - Start >= 1)
            {
                // do loop while i position in the array is before k position
                do
                {
                    // start comparing i with pivot (1 number in the array), if smaller, continue,
                    // if larger, stop. if stop, start comparing k with pivot
                    while (i <= End && x[i] <= x[Start]) { i++; }
                    while (x[k]  > x[Start]) { k--; }

                    // if i stops increasing and k stops decreasing, 
                    // check if i hasn't passed k first, if so, swap start with k
                    // numbers are in the wrong place, swap i with k
                    // swapper:
                    if (i <= k)
                    {
                        int t = x[i];
                        x[i] = x[k];
                        x[k] = t;
                    }
                    else if (i > k)
                    {
                        int t = x[Start];
                        x[Start] = x[k];
                        x[k] = t;
                    }
                }
                while (i <= k);

                // array is merely sorted, now recursively start sorting the left part,
                // and the right part

                // left part:
                qSort(0, k - 1);
                // right part:
                qSort(k + 1, End);
            }
        }
        
        public static void printArray(int[] a2P)
        {
            for (int i = 0; i < a2P.Length; i++)
            {
                Console.Write(" " + a2P[i] + " ");
            }
                Console.WriteLine(" ");

        }
    }
}

