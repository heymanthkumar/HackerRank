using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode
{
    class Loops
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int n = Convert.ToInt32(Console.ReadLine());

            if ((n >= 2) && n <= 20)
            {
                for (int i = 1; i < 11; i++)
                    Console.WriteLine(n + " x " + i + " = " + n * i);
            }
            Console.ReadLine();
        }
    }
}

