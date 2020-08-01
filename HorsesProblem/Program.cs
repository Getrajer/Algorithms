using System;
using System.Collections.Generic;

namespace HorsesProblem
{
    /*
        There are 25 horses. At most, 5 horses can race together at a time. You must
        determine the fastest, second fastest, and third fastest horses.
     */

    class Horse
    {
        public string Name { get; set; }
        public int Time { get; set; }

        public Horse(string name)
        {
            Name = name;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Horse> Horses = new List<Horse>
            {
                new Horse("q"),
                new Horse("w"),
                new Horse("e"),
                new Horse("r"),
                new Horse("t"),
                new Horse("y"),
                new Horse("u"),
                new Horse("i"),
                new Horse("o"),
                new Horse("p"),
                new Horse("a"),
                new Horse("s"),
                new Horse("d"),
                new Horse("f"),
                new Horse("g"),
                new Horse("h"),
                new Horse("j"),
                new Horse("k"),
                new Horse("l"),
                new Horse("z"),
                new Horse("x"),
                new Horse("c"),
                new Horse("v")
            };
        }
    }
}
