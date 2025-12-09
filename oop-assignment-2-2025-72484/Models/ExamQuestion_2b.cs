using System;
using System.Collections.Generic;
using System.Text;

namespace oop_assignment_2_2025_72484.Models
{
    public static class ExamQuestion_2b
    {
        public static void Run()
        {
            Console.WriteLine("---");
            Console.WriteLine("Exam Question 2-B executed.");
                        

            string result3 = ConvertStringToInt("42");
            Console.WriteLine($"(\"42\") Expected: 42. Actual: {result3}");

            string result4 = ConvertStringToInt("abc");
            Console.WriteLine($"(\"abc\") Expected: {result4}");
        }

       
        public static string ConvertStringToInt(string input)
        {
            try
            {
                int result = int.Parse(input);
                return result.ToString();
            }
            catch (FormatException)
            {
                return "Invalid number entered.";
            }
            catch (ArgumentNullException)
            {
                return "Invalid number entered.";
            }
            catch (OverflowException)
            {
                return "Invalid number entered.";
            }
        }
    }
}



