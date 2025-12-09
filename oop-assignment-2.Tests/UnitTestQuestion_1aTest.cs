using Xunit;
using System.Text.RegularExpressions;

namespace oop_assignment_2.Tests;

public class UnitTestQuestion_1aTest
{
    
    private const string IrishMobilePattern = @"^08[359]\d{7}$";
    private readonly Regex mobileRegex = new Regex(IrishMobilePattern);

    
    
    [Theory]
    [InlineData("0831234567")]
    [InlineData("0899988776")]
    [InlineData("0859876543")] 
    [InlineData("0891122334")] 
    public void IsMatch_ShouldReturnTrue_ForValidIrishMobileNumbers(string mobileNumber)
    {
        
        bool isMatch = mobileRegex.IsMatch(mobileNumber);

        
        Assert.True(isMatch, $"Valid number '{mobileNumber}' expcted.");
    }

    [Theory]
    // Invalid case
    [InlineData("0812345678")]
    // Invalid. Missing data
    [InlineData("083123456")]
    // Invalid. Extra data
    [InlineData("08312345678")]
    // Invalid. With space
    [InlineData("083 1234567")]
    // Invalid. With hyphen
    [InlineData("083-1234567")]
    // Invalid case
    [InlineData("0931234567")]
    public void IsMatch_ShouldReturnFalse_ForInvalidIrishMobileNumbers(string mobileNumber)
    {
        
        bool isMatch = mobileRegex.IsMatch(mobileNumber);

        
        Assert.False(isMatch, $"Invalid number '{mobileNumber}' expected.");
    }
}
