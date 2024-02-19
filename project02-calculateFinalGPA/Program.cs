using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_secondProject_calculateFinalGPA
{
    class Program
    {
        static void Main(string[] args)
        {
           string studentName = "Sophia Johnson";

           string[] courseNames = {"English 101", "Algebra 101", "Biology 101", "Computer Science I", "Psychology 101"};

           int[] courseCredits = {3, 3, 4, 4, 3};

           string[] courseGrade = {"A", "B", "B", "B", "A"};

           int[] courseNote = new int[5];

           for (int i = 0; i < courseNames.Length; i++)
           {
                if (courseGrade[i] == "B")
                {
                    courseNote[i] = 3;
                }
                else if (courseGrade[i] == "A")
                {
                    courseNote[i] = 4;
                }
           }

           int totalCredHours = 0;
           int totalGradePoints=0;
           int[] gradsCourse = new int[5];

           for (int i = 0; i < courseNames.Length; i++)
           {
                gradsCourse[i] = courseNote[i] * courseCredits[i];

                totalGradePoints += gradsCourse[i];

                totalCredHours += courseCredits[i];
           }

           double gradePointAverage = (double)totalGradePoints / (double)totalCredHours;

           Console.WriteLine($"\nStudent: {studentName}\n");

           Console.WriteLine("Course\t\t\tGrade\tCredit Hours");

           for (int i = 0; i < courseNames.Length; i++)
           {
                if (courseNames[i] != "Computer Science I") 
                {
                    Console.WriteLine($"{courseNames[i]}\t\t{courseNote[i]}\t{courseCredits[i]}");
                }
                else
                {
                    Console.WriteLine($"{courseNames[i]}\t{courseNote[i]}\t{courseCredits[i]}");
                }
           }

           Console.WriteLine($"Final GPA: {gradePointAverage:F2}\n");

        }
    }
}
