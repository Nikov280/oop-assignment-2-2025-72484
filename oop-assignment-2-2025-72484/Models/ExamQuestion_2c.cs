using System;
using System.Collections.Generic;
using System.Text;

namespace oop_assignment_2_2025_72484.Models
{
    public static class ExamQuestion_2c
    {
        public static void Run()
        {
            Console.WriteLine("---");
            Console.WriteLine("Exam Question 2-C executed.");
            
            string result5 = RegisterUser(25);
            Console.WriteLine($"RegisterUser(25) Expected: {result5}");

            
            string result6 = RegisterUser(15);
            Console.WriteLine($"RegisterUser(15) Expected: {result6}");
        }


        public static string RegisterUser(int age)
        {
            try
            {
                if (age < 18)
                {

                    throw new ArgumentOutOfRangeException(
                        nameof(age),
                        "Age must be 18 or older to register."
                    );
                }


                return "Registration successful.";
            }

            catch (ArgumentOutOfRangeException)
            {

                return "User must be at least 18 to register.";
            }
        }


    }
}


