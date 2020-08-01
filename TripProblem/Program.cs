using System;
using System.Collections.Generic;


/*
    A group of students are members of a club that travels annually to different locations. Their destinations in the past have included Indianapolis, Phoenix, Nashville, Philadelphia, San Jose, and Atlanta. This spring they are planning a trip to Eindhoven.

    The group agrees in advance to share expenses equally, but it is not practical to share every expense as it occurs. Thus individuals in the group pay for particular things, such as meals, hotels, taxi rides, and plane tickets. After the trip, each student's expenses are tallied and money is exchanged so that the net cost to each is the same, to within one cent. In the past, this money exchange has been tedious and time consuming. Your job is to compute, from a list of expenses, the minimum amount of money that must change hands in order to equalize (within one cent) all the students' costs.
 */



namespace TripProblem
{
    class Trip
    {
        public int AmmountOfStudents { get; set; }
        public double SpentMoney { get; set; }
        public double Change { get; set; }
    }


    class TripChange
    {
        //Taking to the considiration that input is valid
        public void CalculateChange(List<double> commands)
        {
            int trip_i = 0;
            Trip trip = new Trip();
            List<Trip> Trips = new List<Trip>();
            List<double> payments = new List<double>();
            for (int i = 0; i <= commands.Count; i++)
            {
                if (trip_i == 0)
                {

                    if (i != 0)
                    {
                        double mean = Math.Round(trip.SpentMoney / trip.AmmountOfStudents);
                        double diffrence = 0;

                        for (int j = 0; j < payments.Count; j++)
                        {
                            if ((payments[j] - mean) < 0)
                            {
                                diffrence += payments[j] - mean;
                            }
                        }

                        trip.Change = Math.Abs(diffrence);
                        Trips.Add(trip);
                    }

                    if(i != commands.Count)
                    {
                        //Reset Variables
                        trip_i = Convert.ToInt32(commands[i]);
                        trip = new Trip();
                        payments = new List<double>();
                    }
                }
                else
                {
                    trip.AmmountOfStudents++;
                    trip.SpentMoney += commands[i];
                    payments.Add(commands[i]);

                    trip_i--;
                }
            }

            for (int i = 0; i < Trips.Count; i++)
            {
                Console.WriteLine($"Ammount of students: {Trips[i].AmmountOfStudents}");
                Console.WriteLine($"Money spent: {Trips[i].SpentMoney}");
                Console.WriteLine($"They need to organize ${Trips[i].Change} of change");
            }

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<double> commands = new List<double>();
            Console.WriteLine("Input valid variables for the problem");

            for (int i = 0; i != 1;)
            {
                double num = Convert.ToDouble(Console.ReadLine());

                if(num == 0)
                {
                    TripChange t = new TripChange();

                    t.CalculateChange(commands);
                    i++;
                }
                else
                {
                    commands.Add(num);
                }
            }
        }
    }
}
