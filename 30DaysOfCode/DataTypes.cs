using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode
{
    class DataTypes
    {
       static void Main()
       {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";
        // Declare second integer, double, and String variables.
        int n;
        double f;
        string c;
        // Read and save an integer, double, and String to your variables.
        n = int.Parse(System.Console.ReadLine());
        f = double.Parse(System.Console.ReadLine());
        c = System.Console.ReadLine();
        // Print the sum of both integer variables on a new line.
        Console.WriteLine(i + n);
        // Print the sum of the double variables on a new line.
        System.Console.WriteLine((d + f).ToString("F1"));
        // Concatenate and print the String variables on a new line
        System.Console.WriteLine(s + c);
        // The 's' variable above should be printed first.

        }      


    }
}
