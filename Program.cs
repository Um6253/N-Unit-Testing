using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NUnitTesting.Program;

namespace NUnitTesting
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
        public class GradeCalculator
        {


            public string GetGradeByPercentage(int percentage)
            {

                if (percentage >= 90 & percentage <= 100)
                {
                       return "A";
                }
               else if (percentage >= 80 && percentage <= 90)
               {

                    return "B";
               }
               else if (percentage >= 70 && percentage <= 80)
               {

                    return "C";
               }
                else if (percentage >= 60 && percentage <= 70)
                { 
                    return "D";
                }

                
                else if (percentage >= 0 && percentage <= 60)
                { 
                    return "F";
                }

                else

                { return "Invalid"; }
            }
        }
    }
}

