using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    internal class PlusMinus
    {
        // Complete the plusMinus function below.
        static void plusMinus(int[] arr)
        {
            int countPositive = 0, countNegative = 0, countZero = 0;
            int arrlength = arr.Length;
            foreach (int i in arr)
            {
                if (i == 0)
                    countZero++;
                else if (i > 0)
                    countPositive++;
                else
                    countNegative++;
            }
            Console.WriteLine((double)countPositive / arrlength);
            Console.WriteLine((double)countNegative / arrlength);
            Console.WriteLine((double)countZero / arrlength);
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;
            plusMinus(arr);
        }
    }
}
