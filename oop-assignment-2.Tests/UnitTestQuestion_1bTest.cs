using Xunit;
using System.Text.RegularExpressions;
using oop_assignment_2_2025_72484.Models;

namespace oop_assignment_2.Tests;

public class ExamTestQuestion_1bTest
{    
    
        [Theory(DisplayName = "Q1-B: Discount - It should be correct porcetage")]
        [InlineData("Bronze", 1)]
        [InlineData("Silver", 5)]
        [InlineData("Gold", 10)]
        [InlineData("Platinum", 15)]
        [InlineData("Diamond", 20)]
        [InlineData("Elite", 25)]
        [InlineData("VIP", 30)]
        public void GetDiscountPercentage_Refactored_ShouldReturnCorrectDiscount(string level, int expectedDiscount)
        {
            
            int actualDiscount = ExamQuestion_1b.GetDiscountPercentage(level);

            
            Assert.Equal(expectedDiscount, actualDiscount);
        }

        [Theory(DisplayName = "Q1-B: Discount - It should be zero for unknown value")]
        [InlineData("Standard")]
        [InlineData("InvalidLevel")]
        [InlineData(null)] 
        [InlineData("")]    
        public void GetDiscountPercentage_ShouldReturnZero_ForUnknownLevels(string level)
        {
            
            int actualDiscount = ExamQuestion_1b.GetDiscountPercentage(level);

            
            Assert.Equal(0, actualDiscount);
        }

    
}
