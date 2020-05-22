using System;

namespace SimpleConcepts.Extensions
{
    public static class GuidNullableNumberExtensions
    {
        public static Guid? ToGuid(this long? input)
        {
            return input?.ToGuid();
        }

        public static Guid? ToGuid(this int? input)
        {
            return input?.ToGuid();
        }

        public static Guid? ToGuid(this short? input)
        {
            return input?.ToGuid();
        }

        public static long? ToInt64(this Guid? input)
        {
            return input?.ToInt64();
        }

        public static int? ToInt32(this Guid? input)
        {
            return input?.ToInt32();
        }

        public static short? ToInt16(this Guid? input)
        {
            return input?.ToInt16();
        }
    }
}
