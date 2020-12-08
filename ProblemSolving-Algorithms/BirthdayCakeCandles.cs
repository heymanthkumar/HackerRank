using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

namespace ProblemSolving_Algorithms
{
    class BirthdayCakeCandles
    {
        public static void Main(string[] args)
        {
            int candlesCount = Convert.ToInt32(Console.ReadLine().Trim());
            var height = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var max = height.Max();
            var count = height.Count(t => t == max);
            Console.WriteLine(count);
        }
    }
}
