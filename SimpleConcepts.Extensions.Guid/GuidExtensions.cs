using System;
using System.Globalization;

namespace SimpleConcepts.Extensions
{
    public static class GuidExtensions
    {
        public static Guid ToZeroPaddedGuid(this long input)
        {
            if (input < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(input), "Value must be zero or positive.");
            }

            return Guid.Parse(input.ToString("D32", CultureInfo.InvariantCulture));
        }

        public static Guid ToZeroPaddedGuid(this int input)
        {
            if (input < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(input), "Value must be zero or positive.");
            }

            return Guid.Parse(input.ToString("D32", CultureInfo.InvariantCulture));
        }

        public static Guid ToZeroPaddedGuid(this short input)
        {
            if (input < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(input), "Value must be zero or positive.");
            }

            return Guid.Parse(input.ToString("D32", CultureInfo.InvariantCulture));
        }

        public static long ToInt64(this Guid input)
        {
            if (long.TryParse(input.ToString("N"), out var result))
            {
                return result;
            }

            throw new ArgumentException("Value cannot be converted to Int64.", nameof(input));
        }

        public static int ToInt32(this Guid input)
        {
            if (int.TryParse(input.ToString("N"), out var result))
            {
                return result;
            }

            throw new ArgumentException("Value cannot be converted to Int32.", nameof(input));
        }

        public static short ToInt16(this Guid input)
        {
            if (short.TryParse(input.ToString("N"), out var result))
            {
                return result;
            }

            throw new ArgumentException("Value cannot be converted to Int16.", nameof(input));
        }
    }
}
