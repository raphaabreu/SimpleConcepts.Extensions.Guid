using System;
using Xunit;

namespace SimpleConcepts.Extensions.Tests
{
    public class GuidExtensionsTests
    {
        [Fact]
        public void ToZeroPaddedGuid_WithPositiveInt64_ReturnsCorrectValue()
        {
            // Arrange
            var input = long.MaxValue;

            // Act
            var result = input.ToZeroPaddedGuid();

            // Assert
            Assert.Equal(Guid.Parse("00000000000009223372036854775807"), result);
        }

        [Fact]
        public void ToZeroPaddedGuid_WithNegativeInt64_Throws()
        {
            // Arrange
            var input = long.MinValue;

            // Act
            void act()
            {
                input.ToZeroPaddedGuid();
            }

            // Assert
            var ex = Assert.Throws<ArgumentOutOfRangeException>(act);
            Assert.Equal("Value must be zero or positive. (Parameter 'input')", ex.Message);
        }

        [Fact]
        public void ToZeroPaddedGuid_WithPositiveInt32_ReturnsCorrectValue()
        {
            // Arrange
            var input = int.MaxValue;

            // Act
            var result = input.ToZeroPaddedGuid();

            // Assert
            Assert.Equal(Guid.Parse("00000000000000000000002147483647"), result);
        }

        [Fact]
        public void ToZeroPaddedGuid_WithNegativeInt32_Throws()
        {
            // Arrange
            var input = int.MinValue;

            // Act
            void act()
            {
                input.ToZeroPaddedGuid();
            }

            // Assert
            var ex = Assert.Throws<ArgumentOutOfRangeException>(act);
            Assert.Equal("Value must be zero or positive. (Parameter 'input')", ex.Message);
        }

        [Fact]
        public void ToZeroPaddedGuid_WithPositiveInt16_ReturnsCorrectValue()
        {
            // Arrange
            var input = short.MaxValue;

            // Act
            var result = input.ToZeroPaddedGuid();

            // Assert
            Assert.Equal(Guid.Parse("00000000000000000000000000032767"), result);
        }

        [Fact]
        public void ToZeroPaddedGuid_WithNegativeInt16_Throws()
        {
            // Arrange
            var input = short.MinValue;

            // Act
            void act()
            {
                input.ToZeroPaddedGuid();
            }

            // Assert
            var ex = Assert.Throws<ArgumentOutOfRangeException>(act);
            Assert.Equal("Value must be zero or positive. (Parameter 'input')", ex.Message);
        }

        [Fact]
        public void ToInt64_WithNumericGuid_ReturnsCorrectValue()
        {
            // Arrange
            var input = Guid.Parse("00000000000009223372036854775807");

            // Act
            var result = input.ToInt64();

            // Assert
            Assert.Equal(long.MaxValue, result);
        }

        [Fact]
        public void ToInt64_WithNonNumericGuid_Throws()
        {
            // Arrange
            var input = Guid.NewGuid();

            // Act
            void act()
            {
                input.ToInt64();
            }

            // Assert
            var ex = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Value cannot be converted to Int64. (Parameter 'input')", ex.Message);
        }

        [Fact]
        public void ToInt32_WithNumericGuid_ReturnsCorrectValue()
        {
            // Arrange
            var input = Guid.Parse("00000000000000000000002147483647");

            // Act
            var result = input.ToInt32();

            // Assert
            Assert.Equal(int.MaxValue, result);
        }

        [Fact]
        public void ToInt32_WithNonNumericGuid_Throws()
        {
            // Arrange
            var input = Guid.NewGuid();

            // Act
            void act()
            {
                input.ToInt32();
            }

            // Assert
            var ex = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Value cannot be converted to Int32. (Parameter 'input')", ex.Message);
        }

        [Fact]
        public void ToInt16_WithNumericGuid_ReturnsCorrectValue()
        {
            // Arrange
            var input = Guid.Parse("00000000000000000000000000032767");

            // Act
            var result = input.ToInt16();

            // Assert
            Assert.Equal(short.MaxValue, result);
        }

        [Fact]
        public void ToInt16_WithNonNumericGuid_Throws()
        {
            // Arrange
            var input = Guid.NewGuid();

            // Act
            void act()
            {
                input.ToInt16();
            }

            // Assert
            var ex = Assert.Throws<ArgumentException>(act);
            Assert.Equal("Value cannot be converted to Int16. (Parameter 'input')", ex.Message);
        }
    }
}
