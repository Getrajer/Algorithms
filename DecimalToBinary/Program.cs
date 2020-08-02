using System;
using System.Collections.Generic;

namespace DecimalToBinary
{

    class DtB
    {
        public void Convert(double number)
        {
            List<int> binary = new List<int>();
            double pow_two = 1;
            double two = 2;

            bool ifOdd = (number % 2) == 1;

            for(int i = 0; i < 1;)
            {
                double pow_nr = Math.Pow(two, pow_two);

                if (pow_nr == number)
                {
                    for (int j = 0; j < 1;)
                    {
                        if((number - Math.Pow(two, pow_two)) >= 0)
                        {
                            number = number - Math.Pow(two, pow_two);
                            binary.Add(1);
                            pow_two--;

                            if(pow_two == 1)
                            {
                                j++;
                            }
                        }
                        else
                        {
                            pow_two--;
                            binary.Add(0);

                            if (pow_two == 1)
                            {
                                j++;
                            }
                        }
                    }
                    i++;
                }
                else if(pow_nr > number)
                {
                    pow_two--;

                    for (int j = 0; j < 1;)
                    {
                        if ((number - Math.Pow(two, pow_two)) >= 0)
                        {
                            number = number - Math.Pow(two, pow_two);
                            binary.Add(1);
                            pow_two--;

                            if (pow_two == 0)
                            {
                                if (ifOdd) binary.Add(1); else binary.Add(0);
                                j++;
                            }
                        }
                        else
                        {
                            pow_two--;
                            binary.Add(0);

                            if (pow_two == 0)
                            {
                                if (ifOdd) binary.Add(1); else binary.Add(0);
                                j++;
                            }
                        }
                    }
                    i++;
                }
                else
                {
                    pow_two++;
                }
            }

            for (int i = 0; i < binary.Count; i++)
            {
                Console.Write(binary[i]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int number = 75;
            DtB dt = new DtB();
            Console.WriteLine(number);
            Console.WriteLine("As binary");
            dt.Convert(number);
        }
    }
}
