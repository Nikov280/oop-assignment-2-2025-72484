using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment_2_2025_72484.Models
{
    public static class ExamQuestion_4a
    {
        public static void Run()
        {
            Console.WriteLine("---");
            Console.WriteLine("Exam Question 4-A executed.");
            Console.WriteLine(FormatFiveDigits(42));
        }
        public static string FormatFiveDigits(int input)
        {
            
            return input.ToString("D5");
        }
    }
}
