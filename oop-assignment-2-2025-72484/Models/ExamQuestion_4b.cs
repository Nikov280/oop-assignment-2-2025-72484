using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment_2_2025_72484.Models
{
    public class ExamQuestion_4b
    {
        public static void Run()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("---");
            Console.WriteLine("Exam Question 4-B executed.");
            Console.WriteLine(FormatPrice(1234.5));
            
        }
        public static string FormatPrice(double input)
        {
            
            string formattedNumber = string.Format(CultureInfo.GetCultureInfo("en-US"), "{0:N2}", input);

            
            return $"€{formattedNumber}";
        }
    }
}
