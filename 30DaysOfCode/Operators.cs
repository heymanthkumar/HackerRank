using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30DaysOfCode
{
    class Operators
    {
        // Complete the solve function below.
        static void solve(double meal_cost, int tip_percent, int tax_percent)
        {
            double result = meal_cost + meal_cost * tip_percent / 100 + meal_cost * tax_percent / 100;
            Console.WriteLine("Total Bill : " + result.ToString("F0"));
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter meal cost");
            double meal_cost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Tip percentage");
            int tip_percent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Tax percentage");
            int tax_percent = Convert.ToInt32(Console.ReadLine());

            solve(meal_cost, tip_percent, tax_percent);
        }
    }
}
