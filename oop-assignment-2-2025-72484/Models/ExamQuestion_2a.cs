using System;
using System.Collections.Generic;
using System.Text;

namespace oop_assignment_2_2025_72484.Models
{
    public static class ExamQuestion_2a
    {
        public static void Run()
        {
            Console.WriteLine("---");
            Console.WriteLine("Exam Question 2-A executed.");

            string result1 = Divide(10, 2);
            Console.WriteLine($"Divide(10, 2) Expected: {result1}");

            string result2 = Divide(10, 0);
            Console.WriteLine($"Divide(10, 0) Expected: {result2}");
        }

        public static string Divide(int numerator, int denominator)
        {
            try
            {
                if (denominator == 0)
                {
                    return "Cannot divide by zero.";
                }

                double result = (double)numerator / denominator;
                return result.ToString();
            }
            catch (Exception)
            {
                return "An unknown error occurred.";
            }
        }
    }
}





