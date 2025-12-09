using oop_assignment_2_2025_72484.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_assignment_2.Tests
{
    public class UnitTestQuestion_4aTest
    {
        [Theory(DisplayName = "Q4-A: Formato - Debe rellenar con ceros a la izquierda para 5 dígitos")]
        [InlineData(42, "00042")]    // El ejemplo principal
        [InlineData(1, "00001")]
        [InlineData(12345, "12345")] // Sin relleno necesario
        [InlineData(123, "00123")]
        public void FormatFiveDigits_ShouldPadWithLeadingZeros(int input, string expectedOutput)
        {
            // Act
            string actualOutput = ExamQuestion_4a.FormatFiveDigits(input);

            // Assert
            Assert.Equal(expectedOutput, actualOutput);
            Assert.Equal(5, actualOutput.Length); // Verifica la longitud
        }
    }
}
