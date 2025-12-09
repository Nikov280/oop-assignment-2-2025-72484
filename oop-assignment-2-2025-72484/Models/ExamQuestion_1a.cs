using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace oop_assignment_2_2025_72484.Models
{
    public static class ExamQuestion_1a
    {
        public static void Run()
        {
            Console.WriteLine("---");
            Console.WriteLine("Exam Question 1-A executed.");
            SampleQuestionMethod();
        }

        public static void SampleQuestionMethod()
        {
            
            var mobileNumber = "0831234567";
            var pattern = @"^08[359]\d{7}$";
            bool isValid = Regex.IsMatch(mobileNumber, pattern);

            Console.WriteLine($"Test number '{mobileNumber}' is valid: {isValid}");
            
        }
    }
}

