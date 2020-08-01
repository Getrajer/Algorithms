using System;
using System.Collections.Generic;

namespace FibbonaciSequence
{
    class FibonacciSequence
    {
        public void PrintSequence(int count)
        {
            if (count <= 0)
            {
                Console.WriteLine("Number needs to be bigger than 0");
            }
            else
            {
                List<int> numbers = new List<int>();

                if (count == 1)
                {
                    Console.WriteLine("1");
                }
                else if (count == 2)
                {
                    Console.WriteLine("1, 1");
                }
                else
                {
                    numbers.Add(1);
                    numbers.Add(1);
                    Console.Write("1, 1, ");

                    for (int i = (count - 2); i != 0; i--)
                    {
                        numbers.Add(numbers[numbers.Count - 1] + numbers[numbers.Count - 2]);
                        Console.Write($"{numbers[numbers.Count - 1]}, ");
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FibonacciSequence f = new FibonacciSequence();

            f.PrintSequence(8);
        }
    }
}
