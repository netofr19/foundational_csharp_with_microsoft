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

           string[] courseGrade = new string[5];

           for (int i = 0; i < courseNames.Length; i++)
           {
                if (courseCredits[i] == 3)
                {
                    courseGrade[i] = "B";
                }
                else if (courseCredits[i] == 3)
                {
                    courseGrade[i] = "A";
                }
           }

           for (int i = 0; i < courseNames.Length; i++)
           {
                Console.WriteLine($"{courseNames[i]} {courseGrade[i]} {courseCredits[i]}");
           }
        }
    }
}
