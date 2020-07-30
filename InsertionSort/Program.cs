using System;

namespace InsertionSort
{
   class InsertionSort
    {
        public int[] Sort(int[] array)
        {
            int j;

            for(int i = 1; i < array.Length; i++)
            {
                j = i;

                while((j > 0) && (array[j] < array[j - 1]))
                {
                    int buffer = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = buffer;
                    j--;
                }
            }

            return array;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            int[] variables = new int[] { 3, 4, 32, 2, 1, 43, 3, 3, 5, 6 };

            InsertionSort s = new InsertionSort();

            int[] sorted = s.Sort(variables);

            for(int i = 0; i < sorted.Length; i++)
            {
                Console.Write($"|{sorted[i]}|");
            }
            
        }
    }
}
