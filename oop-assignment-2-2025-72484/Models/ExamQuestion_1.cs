using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace oop_assignment_2_2025_72484.Models
{
    public static class ExamQuestion_1
    {
        public static void Run()
        {
            Console.WriteLine("Exam Question 1 executed.");
            SampleQuestionAMethod();
            SampleQuestionBMethod();
            Console.WriteLine(GetDiscountPercentage("Platinum"));
        }
        public static void SampleQuestionAMethod()
        {
            // Sample method implementation
            Console.WriteLine("SampleMethod");
        }

        public static void SampleQuestionBMethod()
        {
            // Sample method implementation
            Console.WriteLine("SampleMethod");
        }
        public static int GetDiscountPercentage(string level)
        {
            if (level == "Bronze")
            {
                return 1;
            }
            else
            {
                if (level == "Silver")
                {
                    return 5;
                }
                else
                {
                    if (level == "Gold")
                    {
                        return 10;
                    }
                    else
                    {
                        if (level == "Platinum")
                        {
                            return 15;
                        }
                        else
                        {
                            if (level == "Diamond")
                            {
                                return 20;
                            }
                            else
                            {
                                if (level == "Elite")
                                {
                                    return 25;
                                }
                                else
                                {
                                    if (level == "VIP")
                                    {
                                        return 30;
                                    }
                                    else
                                    {
                                        return 0; // Unknown level
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

    }
}

