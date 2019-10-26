using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class test
    {
        public void Run()
        {
            int[] array = new int[] { 1, 2, 3, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(binary_search(array, 20));
            Console.WriteLine(array.Length);
        }
        public int binary_search(int[] array, int item)
        {
            int low = 0;
            int high = array.Length - 1;
            int mid = 0;
            int guess = 0;
            int result = 0;
            while (low <= high)
            {
                mid = (low + high) / 2;
                guess = array[mid];
                if (guess == item)
                {
                    result = mid;
                    if (guess > item)
                        high = mid - 1;
                    else
                        low = mid + 1;
                }
                else return -1;
            }
            return result;
        }
    }
}