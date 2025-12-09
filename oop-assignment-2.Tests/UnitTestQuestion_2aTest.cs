using oop_assignment_2_2025_72484.Models;

namespace oop_assignment_2.Tests
{
    public class UnitTestQuestion_2aTest
    {
        [Theory(DisplayName = "Q2-A: Division - Should be valid division")]
        [InlineData(10, 2, "5")]
        [InlineData(10, 3, "3.3333333333333335")]
        [InlineData(-20, 4, "-5")]
        [InlineData(0, 5, "0")]
        public void Divide_ShouldReturnCorrectResult_ForValidInputs(int numerator, int denominator, string expectedOutput)
        {
            
            string actualOutput = ExamQuestion_2a.Divide(numerator, denominator);

            
            Assert.Equal(expectedOutput, actualOutput);
        }

        
        [Fact(DisplayName = "Q2-A: Division - Should warn it can be by zero")]
        public void Divide_ShouldReturnErrorMessage_WhenDenominatorIsZero()
        {
            
            int numerator = 10;
            int denominator = 0;
            const string expectedMessage = "Cannot divide by zero.";

            
            string actualOutput = ExamQuestion_2a.Divide(numerator, denominator);

            
            Assert.Equal(expectedMessage, actualOutput);
        }
    }
}
