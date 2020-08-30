using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode
{
    class Arrays
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] ar = Console.ReadLine().Split(' ');
            for(int i=ar.Length; i>0; i--)
            {
                Console.Write(ar[i-1] + " ");
            }
        }
    }
}
