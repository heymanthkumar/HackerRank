using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProblemSolving_Algorithms
{
    //https://www.hackerrank.com/challenges/diagonal-difference/problem
    class DiagonalDifference
    {

        /*
         * Complete the 'diagonalDifference' function below.
         *
         * The function is expected to return an INTEGER.
         * The function accepts 2D_INTEGER_ARRAY arr as parameter.
         */

        public static int diagonalDifference(List<List<int>> arr)
        {
            int dimension = arr.Count;
            int firstSum = 0, secondSum = 0;

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    if (i == j)
                        firstSum += arr[i][j];

                    if (j == (dimension - i - 1))
                        secondSum += arr[i][j];
                }
            }
            return Math.Abs(firstSum - secondSum);
        }

    }

    class Solution
    {
        public static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = DiagonalDifference.diagonalDifference(arr);
            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
