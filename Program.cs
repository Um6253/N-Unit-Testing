using System;
using Nunit_Testing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nunit_Testing
{
    internal class Program
    {
        static void Main(string[] args)
        {
             var gradeCalculator = new GradeCalculator();

            Console.Write("Enter the percentage : ");

            var percentage = Convert.ToInt32(Console.ReadLine()); 

            var grade = gradeCalculator.GetGradeByPercentage(percentage);

            // Print grade
            Console.WriteLine($"Student Grade : {grade}");
        }
    }
}
