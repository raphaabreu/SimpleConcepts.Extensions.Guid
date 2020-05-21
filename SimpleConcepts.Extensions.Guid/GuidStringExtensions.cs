using System;

namespace SimpleConcepts.Extensions
{
    public static class GuidStringExtensions
    {
        public static Guid ParseAsGuid(this string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                throw new ArgumentNullException(nameof(input), "Cannot be null or empty");
            }

            return Guid.Parse(input);
        }

        public static Guid? TryParseAsGuid(this string input)
        {
            if (Guid.TryParse(input, out var result))
            {
                return result;
            }

            return null;
        }
    }
}