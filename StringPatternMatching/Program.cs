using System;

namespace StringPatternMatching
{
    class PatternFinder
    {
        public void Pattern(string text, string pattern_string)
        {
            int counter = 0;
            int beginIndex = 0;
            int endIndex = 0;

            for(int i = 0; i < pattern_string.Length; i++)
            {
                if(pattern_string[i] == text[counter])
                {
                    if(counter == 0)
                    {
                        beginIndex = i;
                    }
                    
                    counter++;
                    if(counter == text.Length)
                    {
                        endIndex = i;
                        break;
                    }
                }
                else
                {
                    beginIndex = 0;
                    counter = 0;
                    endIndex = 0;
                }
            }

            if(counter == 0)
            {
                Console.WriteLine("Strings are not having matching patterns");
            }
            else
            {
                Console.WriteLine($"Strings have matching patterns.");
                Console.WriteLine($"String '{text}' is having matching pattern to string: ");
                Console.WriteLine($"{pattern_string}");
                Console.WriteLine($"At indexes from {beginIndex} to {endIndex}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string text = "matching";
            string pattern_string = "Pattern matching is the most fundamental algorithmic operation on text strings";

            PatternFinder p = new PatternFinder();
            p.Pattern(text, pattern_string);
        }
    }
}
