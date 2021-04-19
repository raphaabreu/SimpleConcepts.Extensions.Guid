using System;
using Xunit;

namespace SimpleConcepts.Extensions.Tests
{
    public class SequentialGuidTests
    {
        [Fact]
        public void NewGuid_CalledSequentially_ProducesSequentialGuid()
        {
            // Act
            var first = SequentialGuid.NewGuid();
            var second = SequentialGuid.NewGuid();

            // Assert
            var firstCounter = GetSequentialPart(first);
            var secondCounter = GetSequentialPart(second);

            Assert.True(secondCounter > firstCounter);
        }

        private static long GetSequentialPart(Guid input)
        {
            var bytes = input.ToByteArray();
            var sequence = new byte[8];

            sequence[0] = bytes[9];
            sequence[1] = bytes[8];
            sequence[2] = bytes[15];
            sequence[3] = bytes[14];
            sequence[4] = bytes[13];
            sequence[5] = bytes[12];
            sequence[6] = bytes[11];
            sequence[7] = bytes[10];

            return BitConverter.ToInt64(sequence);
        }
    }
}