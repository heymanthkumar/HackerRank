using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProblemSolving_Algorithms
{
    internal class CamelCase
    {
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
