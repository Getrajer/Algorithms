using System;
using System.Collections.Generic;
using System.Linq;

namespace SelectingRightJobs
{

    class Job
    {
        public int BeginJob { get; set; }
        public int EndJob { get; set; }
        public string Name { get; set; }

        public Job(int begin, int end, string name)
        {
            BeginJob = begin;
            EndJob = end;
            Name = name;
        }
    }

    /*
        films pays the same fee per film    
    
        Problem: Movie Scheduling Problem
        Input: A set I of n intervals on the line.
        Output: What is the largest subset of mutually non-overlapping intervals which can
        be selected from I?
     */

    class FromFirstThenNext
    {
        public void Sort(List<Job> jobs)
        {
            if(jobs != null)
            {
                //Sort the jobs by begin time
                jobs = jobs.OrderBy(o => o.BeginJob).ToList();

                List<Job> JobsDone = new List<Job>();

                for(int i = 0; i < jobs.Count; i++)
                {
                    if(i == 0) 
                    { 
                        JobsDone.Add(jobs[i]); 
                    }
                    else
                    {
                        if(jobs[i - 1].EndJob <= jobs[i].BeginJob)
                        {
                            JobsDone.Add(jobs[i]);
                        }
                        else
                        {
                            i++;
                        }
                    }
                }

                Console.WriteLine("Solution with first variable start next when first ends and so on");

                for(int i = 0; i < JobsDone.Count; i++)
                {
                    Console.WriteLine($"{JobsDone[i].Name} | Begin {JobsDone[i].BeginJob} | End {JobsDone[i].EndJob}");
                }

                Console.WriteLine($"You have done {JobsDone.Count} jobs with this algorithm");
                Console.WriteLine();
            }
        }

    }


    class GreedyAlgorithm
    {
        public void Sort(List<Job> jobs)
        {
            if (jobs != null) 
            {
                //Sort Jobs by end time
                jobs = jobs.OrderBy(o => o.EndJob).ToList();

                List<Job> JobsDone = new List<Job>();

                for (int i = 0; i < jobs.Count; i++)
                {
                    if (i == 0)
                    {
                        JobsDone.Add(jobs[i]);
                    }
                    else
                    {
                        if(jobs[i].BeginJob >= JobsDone[JobsDone.Count - 1].EndJob)
                        {
                            JobsDone.Add(jobs[i]);
                        }
                    }
                }


                Console.WriteLine("Solution with greedy algorithm");

                for (int i = 0; i < JobsDone.Count; i++)
                {
                    Console.WriteLine($"{JobsDone[i].Name} | Begin {JobsDone[i].BeginJob} | End {JobsDone[i].EndJob}");
                }

                Console.WriteLine($"You have done {JobsDone.Count} jobs with this algorithm");
                Console.WriteLine();
            }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            List<Job> Jobs = new List<Job>
            {
                new Job(1, 3, "Jungle"),
                new Job(1, 4, "Algorist"),
                new Job(4, 7, "Problem"),
                new Job(6, 9, "Termintated"),
                new Job(5, 6, "Programing"),
                new Job(2, 3, "Mathematics"),
                new Job(3, 4, "State"),
                new Job(7, 9, "Bets"),
                new Job(4, 5, "Tree"),
            };


            FromFirstThenNext s1 = new FromFirstThenNext();
            GreedyAlgorithm s2 = new GreedyAlgorithm();

            s1.Sort(Jobs);
            s2.Sort(Jobs);
        }
    }
}
