using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProblemSolving_Algorithms
{
    //https://www.hackerrank.com/challenges/compare-the-triplets/problem
    class CompareTheTriplets
    {
        // Complete the compareTriplets function below.
        static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int[] res = new int[2] { 0, 0 };
            for (int i = 0; i < a.Count(); i++)
            {
                if (a[i] > b[i])
                    res[0] = res[0] + 1;
                else if (a[i] < b[i])
                    res[1] = res[1] + 1;
                else
                    continue;
            }
            return res.ToList();
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
            List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
            List<int> b = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();
            List<int> result = compareTriplets(a, b);
            textWriter.WriteLine(String.Join(" ", result));

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
