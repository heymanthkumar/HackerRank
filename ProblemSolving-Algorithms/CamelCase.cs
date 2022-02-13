using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    internal class CamelCase
    {
        // Complete the camelcase function below.
        static int camelcase(string s)
        {
            int i = 1;
            foreach (char c in s)
            {
                if (Char.IsUpper(c))
                    i = i + 1;
            }
            return i;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            string s = Console.ReadLine();

            int result = camelcase(s);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}

