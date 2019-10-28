using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Concat
    {
        public void Run()
        {
            var arr1 = new int[] { 1, 2, 3 };
            var arr2 = new int[] { 4, 5, 6 };
            var arr3 = Concat_(arr1, arr2);
            View(arr3);
        }

        public static int[] Concat_(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];
            int i = 0;
            int j = left.Length;
            int k = 0;
            while(i < result.Length - right.Length)
            { 
                    result[i] = left[i];
                i++;
            }

            while (k < right.Length)
            {
                while (j < result.Length)
                {

                    result[j] = right[k];
                    j++;
                    k++;
                }
            }
         
            return result;
        }

        public static void View(int[] arr)
        {
            Console.Write("[");
            foreach (var item in arr)
            {
                Console.Write($"{item}, ");
            }
            Console.WriteLine("]");
        }
    }
}

