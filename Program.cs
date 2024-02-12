using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StudentGrades.Program;

namespace StudentGrades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Get percentage
            var gradeCalculator = new GradeCalculator();

            Console.Write("Enter the percentage : ");
            var percentage = Convert.ToInt32(Console.ReadLine());
           

             var grade = gradeCalculator.GetGradeByPercentage(percentage);

             Console.WriteLine($"Student Grade : {grade}");

        }
        
    }
}

