using System;
using System.Collections.Generic;

/*
    Write a program with use of stack which will check syntax of brackets in the code(Taking to considiration valid bracet input to the check)
 */

namespace BracketChecker
{

    class Stack
    {
        private int Size = 0;
        LinkedList<string> stack_items = new LinkedList<string>();

        public void Add(string str)
        {
            stack_items.AddFirst(str);
            Size++;
        }

        public void Remove()
        {
            stack_items.RemoveFirst();
            Size--;
        }

        public string PeekTop()
        {
            return stack_items.First.Value.ToString();
        }

        public int Count()
        {
            return Size;
        }
    }

    class BracketChecker
    {
        public bool IsSequenceValid(string[] brackets)
        {
            Stack stack = new Stack();

            for(int i = 0; i < brackets.Length; i++)
            {
                switch (brackets[i])
                {
                    case "{":
                        {
                            stack.Add("{");
                            break;
                        }
                    case "}":
                        {
                            if(stack.Count() == 0)
                            {
                                return false;
                            }
                            else if(stack.PeekTop() == "{")
                            {
                                stack.Remove();
                            }
                            else
                            {
                                return false;
                            }

                            break;
                        }
                    case "[":
                        {
                            stack.Add("[");
                            break;
                        }
                    case "]":
                        {
                            if(stack.Count() == 0)
                            {
                                return false;
                            }
                            else if(stack.PeekTop() == "[")
                            {
                                stack.Remove();
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                    case "(":
                        {
                            stack.Add("(");
                            break;
                        }
                    case ")":
                        {
                            if(stack.Count() == 0)
                            {
                                return false;
                            }
                            else if(stack.PeekTop() == "(")
                            {
                                stack.Remove();
                            }
                            else
                            {
                                return false;
                            }
                            break;
                        }
                }

            }

            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] brackets1 = new string[] { "{", "[", "]", "}", "(", ")" };
            string[] brackets2 = new string[] { "{", "[", "]", "}", "(", "}" };

            BracketChecker b = new BracketChecker();

            Console.WriteLine(b.IsSequenceValid(brackets1));
            Console.WriteLine(b.IsSequenceValid(brackets2));

        }
    }
}
