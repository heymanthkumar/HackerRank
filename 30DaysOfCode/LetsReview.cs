using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode
{
    class LetsReview
    {
        static void Main(String[] args)
        {

            Console.WriteLine("Enter no of input strings");
            int n = int.Parse(Console.ReadLine());
            string[] s = new string[n];
            Console.WriteLine("Enter a string");
            for (int i = 0; i < n; i++)
            {              
                s[i] = Console.ReadLine();
            }

            for (int i = 0; i < n; i++)
            {
                string test, test1 = null, test2 = null;
                test = s[i];
                for (int j = 0; j < test.Length; j++)
                {
                    if (j % 2 == 0)
                        test1 = test1 + test[j];
                    else
                        test2 = test2 + test[j];
                }
                Console.WriteLine(test1 + " " + test2);
            }

        }
    }
}
