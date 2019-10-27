using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class RecursiveSum
    {
       
        public int Sum(int[] array, int index = 0)
        {
            if (index == array.Length - 1)
                return array[index];
            return array[index] + Sum(array, index + 1);
        }
    }
}
