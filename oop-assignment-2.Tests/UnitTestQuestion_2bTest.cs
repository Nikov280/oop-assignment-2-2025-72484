using oop_assignment_2_2025_72484.Models;

namespace oop_assignment_2.Tests
{
    public class UnitTestQuestion_2bTest
    {
        [Theory(DisplayName = "Convert - Should give back as integer")]
        [InlineData("123", "123")]
        [InlineData("-500", "-500")]
        [InlineData("0", "0")]
        public void ConvertStringToInt_ShouldReturnIntegerAsString_ForValidInput(string input, string expectedOutput)
        {
            
            string actualOutput = ExamQuestion_2b.ConvertStringToInt(input);

            
            Assert.Equal(expectedOutput, actualOutput);
        }

        
        [Theory(DisplayName = "Convert - Should be invalid")]
        [InlineData("abc")]           
        [InlineData("123.45")]        
        [InlineData(null)]            
        [InlineData("999999999999")]  
        public void ConvertStringToInt_ShouldReturnErrorMessage_ForInvalidInput(string input)
        {
            
            const string expectedMessage = "Invalid number entered.";

            
            string actualOutput = ExamQuestion_2b.ConvertStringToInt(input);

            
            Assert.Equal(expectedMessage, actualOutput);
        }
    }
}
