using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class SelectionSort
    {
        public void Run()
        {
            int[] array = new int[5] { 5, 2, 10, 4, 1 };
            Show(Findmin(array));

        }
        public int[] Findmin(int[] array)
        {
            int temp, smallest;
            for (int i = 0; i < array.Length; i++)
            {
                smallest = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[smallest])
                    {
                        smallest = j;
                    }
                }
                temp = array[smallest];
                array[smallest] = array[i];
                array[i] = temp;
            }
            return array;
        }
        public void Show(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
                Console.WriteLine(array[i]);
        }
    }
}
