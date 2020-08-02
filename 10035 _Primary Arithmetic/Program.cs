using System;
using System.Collections.Generic;
using System.Text;

/*
    Children are taught to add multi-digit numbers from right-to-left one digit at a time. Many find the
    “carry” operation - in which a 1 is carried from one digit position to be added to the next - to be a
    significant challenge. Your job is to count the number of carry operations for each of a set of addition
    problems so that educators may assess their difficulty.
 */

class PrimaryArithmetic
{
    //Asuming that user input is valid
    public void CheckOperations(List<string> commands)
    {
        List<int> carryOperations = new List<int>();

        for(int i = 0; i < commands.Count; i++)
        {
            int n = 0;
            carryOperations.Add(n);

            StringBuilder number = new StringBuilder(commands[i]);

            int g = number.Length - 2;
            for(int j = number.Length - 1; g >= 0;)
            {
                int v1 = (int)Char.GetNumericValue(number[j]);
                int v2 = (int)Char.GetNumericValue(number[g]);
                int sum = v1 + v2;

                if(sum >= 10)
                {
                    carryOperations[i]++;
                    number.Remove(g, 2);
                    number.Append(sum);
                    j--;
                    g--;
                }
                else
                {
                    number.Remove(g, 2);
                    number.Append(sum);
                    j--;
                    g--;
                }
            }

            Console.WriteLine($"Number {i + 1} had {carryOperations[i]} carry operations.");
        }
    }
}


namespace _10035__Primary_Arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            PrimaryArithmetic p = new PrimaryArithmetic();
            List<string> commands = new List<string> { "555555", "123456", "123594" };

            p.CheckOperations(commands);
        }
    }
}
