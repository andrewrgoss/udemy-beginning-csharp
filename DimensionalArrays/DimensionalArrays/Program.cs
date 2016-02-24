using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimensionalArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] singleDimensionArray = new int[5];
            singleDimensionArray[0] = 1;
            singleDimensionArray[1] = 4;
            singleDimensionArray[2] = 19;
            singleDimensionArray[3] = 8;
            singleDimensionArray[4] = 7;

            for (int i = 0; i < singleDimensionArray.Length; i++)
            {
                Console.WriteLine("The value at position {0} is {1}", i, singleDimensionArray[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Array dimensions: {0}", singleDimensionArray.Rank);
            Console.WriteLine("Array length: {0}", singleDimensionArray.Length);
            Console.WriteLine();
            Console.WriteLine();

            int[,] array2D = new int[2, 3];
            array2D[0, 0] = 1;
            array2D[0, 1] = 2;
            array2D[0, 2] = 3;
            array2D[1, 0] = 4;
            array2D[1, 1] = 5;
            array2D[1, 2] = 6;

            //for a multi-dimensional array we need nested for loops... one for each dimension
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("The value at position {0},{1} is {2}", i, j, array2D[i, j]);
                }
            }
            Console.WriteLine();
            Console.WriteLine("Array dimensions: {0}", array2D.Rank);
            Console.WriteLine("Array length: {0}", array2D.Length);

            Console.ReadLine();
        }
    }
}
