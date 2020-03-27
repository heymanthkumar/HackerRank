using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    class Staircase
    {
        // Complete the staircase function below.
        static void staircase(int n)
        {
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < n - 1 - i; j++)
                {
                    Console.Write(" ");
                }

                for (var j = 0; j < i + 1; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }

        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            staircase(n);
            Console.ReadLine();
        }
    }
}
