using System;
using System.Collections.Generic;

namespace MultiplyMatrices
{
    class MatricMultiplyier
    {
        public int[,] Multiply(int[,] matric1, int[,] matric2)
        {
            if(matric1.GetUpperBound(1) == matric2.GetUpperBound(0))
            {
                int[,] multipliedMatric = new int[matric1.GetUpperBound(0) + 1, matric2.GetUpperBound(1) + 1];

                for(int i = 0; i <= matric1.GetUpperBound(0); i++)
                {
                    int n = matric1.GetUpperBound(0);
                    int n2 = matric1.GetUpperBound(1);
                    int n3 = matric2.GetUpperBound(0);
                    int n4 = matric2.GetUpperBound(1);

                    for (int j = 0; j <= matric2.GetUpperBound(1); j++)
                    {
                        int number = 0;
                        for(int g = 0; g <= matric2.GetUpperBound(0); g++)
                        {
                            number += matric1[i, g] * matric2[g, j];
                        }

                        multipliedMatric[i, j] = number;
                    }
                }

                return multipliedMatric;
            }
            else
            {
                Console.WriteLine("These are not valid matrices");
                int[,] array = new int[0,0];
                return array;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[,] matric1 = new int[2, 3] { { 0, 3, 5 }, { 5, 5, 2 } };
            int[,] matric2 = new int[3, 2] { { 3, 4 }, { 3, -2 }, { 4, -2 } };

            for(int i = 0; i <= matric1.GetUpperBound(0); i++)
            {

                for(int j = 0; j <= matric1.GetUpperBound(1); j++)
                {
                    Console.Write($"{matric1[i, j]} | ");
                }

                Console.WriteLine();
            }
            Console.WriteLine();


            for (int i = 0; i <= matric2.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matric2.GetUpperBound(1); j++)
                {
                    Console.Write($"{matric2[i, j]} | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            MatricMultiplyier m = new MatricMultiplyier();
            int[,] finalMatric = m.Multiply(matric1, matric2);

            for (int i = 0; i <= finalMatric.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= finalMatric.GetUpperBound(1); j++)
                {
                    Console.Write($"{finalMatric[i, j]} | ");
                }
                Console.WriteLine();
            }
        }
    }
}
