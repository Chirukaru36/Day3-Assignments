using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_assignments
{
    internal class assignment6
    {
        static int CalculateTotalMarks(int subject1, int subject2, int subject3)
        {
            return subject1 + subject2 + subject3;
        }

        static double CalculatePercentage(int totalMarks)
        {
            return (double)totalMarks / 3.0;
        }

        static string CalculateGrade(double percentage)
        {
            if (percentage < 35)
            {
                return "Fail";
            }
            else if (percentage >= 35 && percentage < 45)
            {
                return "Third";
            }
            else if (percentage >= 45 && percentage < 60)
            {
                return "Second";
            }
            else
            {
                return "First";
            }
        }
        static void Main(string[] args)
        {
            int subject1;
            int subject2;
            int subject3;
            Console.WriteLine("enter the first subject marks");
            subject1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the second subject marks");
            subject2 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the third subject marks");
            subject3=Convert.ToInt32(Console.ReadLine());

            int totalMarks = CalculateTotalMarks(subject1, subject2, subject3);
            double percentage = CalculatePercentage(totalMarks);
            Console.WriteLine($"Total Marks:  { totalMarks}");
            Console.WriteLine($"Percentage:  {percentage}");
            }
    }
}

