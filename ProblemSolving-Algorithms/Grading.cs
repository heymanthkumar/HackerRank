using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_Algorithms
{
    internal class Grading
    {
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> newGrades = new List<int>();
            foreach(int grade in grades)
            {
                if (grade < 38)
                {
                    newGrades.Add(grade);
                }
                else
                {
                    int nextMultipleOfFive = ((grade / 5) + 1) * 5;
                    newGrades.Add((nextMultipleOfFive - grade < 3) ? nextMultipleOfFive : grade);
                }
            }
            return newGrades;
        }
        public static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = gradingStudents(grades);

            foreach (int i in result)
                Console.WriteLine(i);           
        }
    }
}
