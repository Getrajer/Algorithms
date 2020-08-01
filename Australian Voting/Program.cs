using System;
using System.Collections.Generic;
using System.Linq;

namespace Australian_Voting
{

    /*
         Australian ballots require that voters rank all the candidates in order of choice. Initially only the first choices are counted, 
        and if one candidate receives more than 50% of the vote then that candidate is elected. However, if no candidate receives more than 50%, 
        all candidates tied for the lowest number of votes are eliminated. Ballots ranking these candidates first are recounted in favor of their highest-ranked non-eliminated candidate. 
        This process of eliminating the weakest candidates and counting their ballots in favor of the preferred non-eliminated candidate continues until one candidate receives more than 50% of the vote,
        or until all remaining candidates are tied.
     */

    class Program
    {

        class Candidate
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int VotesCount { get; set; }

            public Candidate(string name, int id)
            {
                Id = id;
                Name = name;
                VotesCount = 0;
            }
        }

        class AustralianVoting
        {
            public string ReturnWinner(List<string> Votes)
            {
                string winner = "";



                return winner;
            }
        }

        static void Main(string[] args)
        {
            int MaxCandidates = 20;
            int MaxCandidateL = 80;
            int MaxVoters = 100;
            int voters_count = 0;

            List<Candidate> candidates = new List<Candidate> { 
                new Candidate("John Doe", 1),
                new Candidate("Jane Smith", 2),
                new Candidate("Jane Austien", 3),
            };

            List<string> votes = new List<string>();

            Console.WriteLine("Election");

            for(int i = 0; i < 1;)
            {
                for(int j = 0; j < 1;)
                {
                    Console.Write("(MAX = 100) (MIN = 2)Enter number of voters:");
                    voters_count = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();

                    if (voters_count > 100 || voters_count < 2)
                    {
                        Console.WriteLine("Wrong number!");
                        Console.Write("(MAX = 100) (MIN = 2)Enter number of voters:");
                        Console.WriteLine();
                        voters_count = Convert.ToInt32(Console.ReadLine());
                        continue;
                    }

                    j++;
                }

                for(int j = 0; j < voters_count; j++)
                {
                    votes.Add("");

                    for (int g = 0; g < candidates.Count; g++)
                    {
                        for(int c = 0; c < candidates.Count; c++)
                        {
                            Console.Write($"| {candidates[c]} ({c + 1}) | ");
                        }

                        Console.WriteLine();
                        Console.Write($"Choose candidate of {g + 1} choice: ");
                        string vote = Console.ReadLine();
                        Console.Clear();

                        votes[j] += vote + ",";
                    }
                }

                //Turn of voting
                int turn = 0;
                Candidate Winner = new Candidate("Unamed", 999);


                for (int v = 0; v < 1;)
                {
                    for (int j = 0; j < votes.Count; j++)
                    {
                        string[] voter_votes = votes[j].Split(",");
                        int vote = Convert.ToInt32(voter_votes[turn]);

                        for(int c = 0; c < candidates.Count; c++)
                        {
                            if(candidates[c].Id == vote)
                            {
                                candidates[c].VotesCount++;
                            }
                        }
                    }


                    bool tie = false;
                    //Find winner in turn
                    for(int j = 0; j < candidates.Count; j++)
                    {
                        if(candidates[j].VotesCount > Winner.VotesCount)
                        {
                            Winner = candidates[j];
                            tie = false;
                        }
                        else if(candidates[j].VotesCount == Winner.VotesCount)
                        {
                            tie = true;
                        }
                    }

                    if(tie == false)
                    {
                        Console.WriteLine($"Winner is: {Winner.Name}");
                    }
                    else
                    {
                        for(int c = 0; c < candidates.Count; c++)
                        {
                            if(candidates[c].VotesCount != Winner.VotesCount)
                            {
                                candidates.RemoveAt(c);
                                c--;
                            }
                        }

                        for(int c = 0; c < votes.Count; c++)
                        {
                            string[] voter_votes = votes[c].Split(",");

                            for(int o = 0; o < candidates.Count; o++)
                            {
                                int vote = Convert.ToInt32(voter_votes[turn]);
                                if (vote == candidates[o].Id)
                                {
                                    votes.RemoveAt(c);
                                    c--;
                                }
                            }
                        }

                        turn++;
                        continue;
                    }
                    v++;
                }
                i++;
            }
        }
    }
}
