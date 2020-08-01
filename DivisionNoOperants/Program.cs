using System;

namespace DivisionNoOperants
{
    class Program
    {

        class Divisor
        {
            public int Divide(int divided, int divisor)
            {
                int result = 0;
                int prefix = 0;

                if(divided == 0 || divisor == 0)
                {
                    throw new System.DivideByZeroException("You can't divide by 0");
                }

                if(divided < 0 || divisor < 0)
                {
                    prefix = -1;
                }
                else
                {
                    prefix = 1;
                }

                divided = Math.Abs(divided);
                divisor = Math.Abs(divisor);

                for(int i = 0; divided > 0; i++)
                {
                    divided = divided - divisor;
                    result++;
                }

                if(prefix == -1)
                {
                    result -= (result + result);
                    return result;
                }
                else
                {
                    return result;
                }
            }
        }

        static void Main(string[] args)
        {
            Divisor d = new Divisor();

            Console.WriteLine(d.Divide(0, -1));
            Console.WriteLine(d.Divide(4, 2));
            Console.WriteLine(d.Divide(-10, 3));
            Console.WriteLine(d.Divide(33, -12));

        }
    }
}
