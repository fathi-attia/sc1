using Xunit;
using calc2;

namespace calc2.Tests
{
    public class ProgramTests
    {
        [Fact]
        public void AddNumbers_ReturnsCorrectSum()
        {
            // Arrange
            int num1 = 5;
            int num2 = 3;

            // Act
            int result = Program.AddNumbers(num1, num2);

            // Assert
            Assert.Equal(8, result);
        }

        [Fact]
        public void AddNumbers_ReturnsCorrectSum_WithNegativeNumbers()
        {
            // Arrange
            int num1 = -5;
            int num2 = -4;

            // Act
            int result = Program.AddNumbers(num1, num2);

            // Assert
            Assert.Equal(-8, result);
        }

        [Fact]
        public void AddNumbers_ReturnsCorrectSum_WithZero()
        {
            // Arrange
            int num1 = 0;
            int num2 = 0;

            // Act
            int result = Program.AddNumbers(num1, num2);

            // Assert
            Assert.Equal(0, result);
        }
    }
}