using System;

namespace Palindrome
{
    class PalindromeCheck
    {
        public bool IfPalindrome(string word)
        {
            bool isPalindrome = true;

            for(int i = 0, j = word.Length - 1; i < word.Length / 2; i++, j--)
            {
                if(word[i] != word[j])
                {
                    isPalindrome = false;
                }
            }

            return isPalindrome;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string word = "abcba";
            string word2 = "432532fdsfsd";
            PalindromeCheck p = new PalindromeCheck();

            Console.WriteLine(word);
            Console.WriteLine(p.IfPalindrome(word));

            Console.WriteLine(word2);
            Console.WriteLine(p.IfPalindrome(word2));

        }
    }
}
