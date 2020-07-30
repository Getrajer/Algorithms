using System;

namespace Tour_Optymization
{

    class FindShortestTourMyTake
    {
        public void ShortestFinderByNeighbour(int[] array)
        {
            if(array.Length > 0)
            {
                //find the mid point

                int firstPoint = array.Length / 2;
                int rightPoint = 0;
                int leftPoint = 0;

                for(int i = 0; i < array.Length; i += 2)
                {
                    if(i == 0)
                    {
                        Console.Write($"{array[firstPoint]},");
                        rightPoint = firstPoint + 1;
                        leftPoint = firstPoint - 1;
                    }
                    else
                    {
                        Console.Write($"{array[rightPoint]},");
                        Console.Write($"{array[leftPoint]},");
                        rightPoint++;
                        leftPoint--;
                    }
                }

                Console.Write(array[firstPoint]);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] values = new int[] { -21, -5, -1, 0, 1, 3, 11};

            FindShortestTourMyTake finder = new FindShortestTourMyTake();

            finder.ShortestFinderByNeighbour(values);

        }
    }
}
