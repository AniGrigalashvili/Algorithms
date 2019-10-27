using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class quicksort
    {
        public void Run()
        {
            int[] array = new int[] { 1, 2, 3, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(quicksort_(array));
        }
        public int quicksort_(int[] array)
        {
            int P = 0;
            int[] less_array = new int[array.Length];
            int[] greater_array = new int[array.Length];
            if (array.Length < 2)
                return array;
            else
            {
                P = array[0];
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < P)
                    {
                        less_array[i] = array[i];
                    }
                    else
                        greater_array[i] = array[i];
                }

            }
            return quicksort_(less_array) + P + quicksort_(greater_array);

        }
        }

}

