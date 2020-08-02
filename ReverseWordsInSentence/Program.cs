using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReverseWordsInSentence
{
    class ReverseWords
    {
        public string Reverse(string sentence)
        {
            List<char> temp = new List<char>();
            char[] sentence_char = sentence.ToCharArray();
            StringBuilder reversedTemp = new StringBuilder();

            for (int i = 0; i <= sentence_char.Length; i++)
            {
                if(i != sentence_char.Length && sentence[i] != ' ')
                {
                    temp.Add(sentence[i]);
                }
                else
                {
                    for (int j = temp.Count - 1; j >= 0; j--)
                    {
                        reversedTemp.Append(temp[j]);
                    }

                    reversedTemp.Append(' ');

                    temp = new List<char>();
                }
            }

            string reversed = reversedTemp.ToString();
            return reversed;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Hello my reversed words sentence";

            ReverseWords reverse = new ReverseWords();
            string reversed = reverse.Reverse(sentence);

            Console.WriteLine(sentence);
            Console.WriteLine(reversed);
        }
    }
}
