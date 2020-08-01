using System;

namespace _3NP1Problem
{

    class CollatzSequence
    {
        public void PrintSequence(int number)
        {
            for(int i = 0; i != 1;)
            {
                if((number % 2) == 0)
                {
                    number = number / 2;
                    Console.WriteLine(number);
                    if (number == 1) i++;
                }
                else
                {
                    number = (3 * number) + 1;
                    Console.WriteLine(number);
                    if (number == 1) i++;
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CollatzSequence s = new CollatzSequence();

            s.PrintSequence(11);
        }
    }
}
