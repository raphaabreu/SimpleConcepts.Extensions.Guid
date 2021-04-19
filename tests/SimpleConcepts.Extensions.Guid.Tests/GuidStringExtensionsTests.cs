using System;
using Xunit;

namespace SimpleConcepts.Extensions.Tests
{
    public class GuidStringExtensionsTests
    {
        [Fact]
        public void ParseAsGuid_WithNull_Throws()
        {
            // Arrange
            var input = (string)null;

            // Act
            void act()
            {
                _ = input.ParseAsGuid();
            }

            // Assert
            Assert.Throws<ArgumentNullException>("input", act);
        }

        [Fact]
        public void ParseAsGuid_WithSpaces_Throws()
        {
            // Arrange
            var input = "  ";

            // Act
            void act()
            {
                _ = input.ParseAsGuid();
            }

            // Assert
            Assert.Throws<ArgumentNullException>("input", act);
        }

        [Fact]
        public void ParseAsGuid_WithValidGuid_ReturnsGuid()
        {
            // Arrange
            var input = "e439f811-ddf9-42a8-854f-30107898c533";

            // Act
            var result = input.ParseAsGuid();

            // Assert
            Assert.Equal(Guid.Parse("e439f811-ddf9-42a8-854f-30107898c533"), result);
        }

        [Fact]
        public void TryParseAsGuid_WithNull_ReturnsNull()
        {
            // Arrange
            var input = (string)null;

            // Act
            // ReSharper disable once ExpressionIsAlwaysNull
            var result = input.TryParseAsGuid();

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void TryParseAsGuid_WithSpaces_ReturnsNull()
        {
            // Arrange
            var input = "  ";

            // Act
            var result = input.TryParseAsGuid();

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void TryParseAsGuid_WithInvalidGuid_ReturnsNull()
        {
            // Arrange
            var input = "123TestandoUmaStringQualquer";

            // Act
            var result = input.TryParseAsGuid();

            // Assert
            Assert.Null(result);
        }

        [Fact]
        public void TryParseAsGuid_WithValidGuid_ReturnsGuid()
        {
            // Arrange
            var input = "e439f811-ddf9-42a8-854f-30107898c533";

            // Act
            var result = input.TryParseAsGuid();

            // Assert
            Assert.Equal(Guid.Parse("e439f811-ddf9-42a8-854f-30107898c533"), result);
        }

    }
}