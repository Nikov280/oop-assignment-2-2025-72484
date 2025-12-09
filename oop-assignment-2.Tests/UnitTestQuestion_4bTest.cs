using oop_assignment_2_2025_72484.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment_2.Tests
{
    public class UnitTestQuestion_4bTest
    {
        [Theory(DisplayName = "Format - It should apply € symbol, and split in 2 decimals")]
        [InlineData(1234.5, "€1,234.50")]     
        [InlineData(1000000.0, "€1,000,000.00")] 
        [InlineData(5.1, "€5.10")]           
        [InlineData(0, "€0.00")]
        [InlineData(1234567.891, "€1,234,567.89")] 
        public void FormatPrice_ShouldApplyCurrencyAndSeparatorFormat(double input, string expectedOutput)
        {
            
            string actualOutput = ExamQuestion_4b.FormatPrice(input);

            
            Assert.Equal(expectedOutput, actualOutput);
        }
    }
}
