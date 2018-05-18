using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05
{
    public static class ADS_02_AdjacencyMatrix
    {
        public static void InitializeMatrix(int[,] matrix)
        {
            for (int x = 0; x < matrix.GetLength(0); x++)
                for (int y = 0; y < matrix.GetLength(1); y++)
                    matrix[x, y] = 0;
        }


        //===========================================================================================================================
        #region Printing

        public static void PrintMatrix(int[,] matrix)
        {
            Console.Write("\n-------------------------------Adjacency Matrix");
            Console.Write($"\n  ");
            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                Console.Write($"  {x}");
            }

            Console.Write($"\n    ----------------");

            for (int x = 0; x < matrix.GetLength(0); x++)
            {
                Console.Write($"\n{x} ");
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    Console.Write($"  {matrix[x, y]}");
                }
            }
            Console.WriteLine();
        }

        #endregion

        //===========================================================================================================================
        #region Autocreation

        public static int[,] AutoCreateMatrix_01_Undirected()
        {
            int[,] matrix = new int[6, 6];
            InitializeMatrix(matrix);

            matrix[1, 2] = 1;
            matrix[1, 3] = 1;
            matrix[2, 1] = 1;
            matrix[2, 5] = 1;
            matrix[3, 1] = 1;
            matrix[3, 4] = 1;
            matrix[3, 5] = 1;
            matrix[4, 3] = 1;
            matrix[4, 5] = 1;
            matrix[5, 2] = 1;
            matrix[5, 3] = 1;
            matrix[5, 4] = 1;

            return matrix;
        }

        public static int[,] AutoCreateMatrix_02()
        {
            int[,] matrix = new int[6, 6];
            InitializeMatrix(matrix);

            matrix[1, 2] = 1;

            return matrix;
        }

        #endregion
    }
}
