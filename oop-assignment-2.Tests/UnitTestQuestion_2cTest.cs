using oop_assignment_2_2025_72484.Models;

namespace oop_assignment_2.Tests
{
    public class UnitTestQuestion_2cTest
    {
        [Theory(DisplayName = "Registration - Should be success")]
        [InlineData(18)]
        [InlineData(25)]
        [InlineData(80)]
        public void RegisterUser_ShouldReturnSuccessMessage_ForValidAge(int age)
        {
            
            const string expectedMessage = "Registration successful.";

            
            string actualOutput = ExamQuestion_2c.RegisterUser(age);

            
            Assert.Equal(expectedMessage, actualOutput);
        }

        
        [Theory(DisplayName = "Registration - Shoulb be over 18")]
        [InlineData(17)]
        [InlineData(0)]
        [InlineData(-5)]
        public void RegisterUser_ShouldReturnErrorMessage_ForInvalidAge(int age)
        {
            
            const string expectedMessage = "User must be at least 18 to register.";

            
            string actualOutput = ExamQuestion_2c.RegisterUser(age);

            
            Assert.Equal(expectedMessage, actualOutput);
        }
    }
}

