using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    class MiniMaxSum
    {
        static void miniMaxSum(int[] arr)
        {
            int size = 4;
            Array.Sort(arr);
            int min = 0, max = 0;
            for(int i=0; i<size; i++)            
                min = min + arr[i];             

            for (int i = arr.Length; i > (arr.Length - size); i--)            
                max = max + arr[i-1];            

            Console.WriteLine(min + " " + max);
        }
        static void Main(string[] args)
        {
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(arr);
        }
    }
}
