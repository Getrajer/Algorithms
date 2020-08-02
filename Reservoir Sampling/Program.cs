using System;
using System.Collections.Generic;

namespace Reservoir_Sampling
{
    class ReservoirSampling
    {
        public List<int> Sampling(int[] stream, int n, int k)
        {
            List<int> Result = new List<int>();
            Random r = new Random();

            for (int i = 0; i < k; i++)
            {
                int index = r.Next(0, n);
                Result.Add(stream[index]);
            }

            return Result;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ReservoirSampling samp = new ReservoirSampling();

            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            List<int> SampledNumbers = samp.Sampling(numbers, numbers.Length, 4);

            for(int i = 0; i < SampledNumbers.Count; i++)
            {
                Console.Write($"{SampledNumbers[i]}, ");
            }
        }
    }
}
