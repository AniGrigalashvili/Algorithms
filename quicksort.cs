using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class quicksort
    {
        public void Run()
        {
            int[] array = new int[] { 1, 2, 7, 5, 50, 7, 200, 9, 10 };
            int length = array.Length;
            quicksort_(array, 0, length - 1);
            for (int i = 0; i < length; i++)
            {
                Console.Write(array[i]);
            }
        }
        public int Func(int[] array, int low, int high)
        {
            int p = array[high];

            int lowIndex = (low - 1);
            for (int j = low; j < high; j++)
            {
                if (array[j] <= p)
                {
                    lowIndex++;

                    int temp = array[lowIndex];
                    array[lowIndex] = array[j];
                    array[j] = temp;
                }
            }

            int temp1 = array[lowIndex + 1];
            array[lowIndex + 1] = array[high];
            array[high] = temp1;

            return lowIndex + 1;
        }
        public void quicksort_(int[] array, int low, int high)
        {
            if (low < high)
            {
                int Index = Func(array, low, high);
                quicksort_(array, low, Index - 1);
                quicksort_(array, Index + 1, high);
            }
        }
    }

}

