using System;
using System.Collections.Generic;

namespace SelectionSort
{
    class SelectionSort
    {
        public void Sort(List<int> numbers)
        {
            //Before sorting
            Console.WriteLine("Before");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write($"{numbers[i]}, ");
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                int smallest_Id = i;

                for (int j = i + 1; j < numbers.Count; j++)
                {
                    if(numbers[smallest_Id] > numbers[j])
                    {
                        smallest_Id = j;
                    }
                }

                int temp = numbers[i];
                numbers[i] = numbers[smallest_Id];
                numbers[smallest_Id] = temp;
            }

            Console.WriteLine();

            //After Sorting
            Console.WriteLine("After");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write($"{numbers[i]}, ");
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 54, 2, 12, 4, 43, 10, 22, 33, 22 };

            SelectionSort s = new SelectionSort();
            s.Sort(numbers);
        }
    }
}
