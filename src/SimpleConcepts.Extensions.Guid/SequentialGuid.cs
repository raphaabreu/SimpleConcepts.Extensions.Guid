using System.Threading;

// ReSharper disable once CheckNamespace
namespace System
{
    public static class SequentialGuid
    {
        private static long _ticks = DateTime.UtcNow.Ticks;

        public static Guid NewGuid()
        {
            var tickBytes = BitConverter.GetBytes(Interlocked.Increment(ref _ticks));

            if (!BitConverter.IsLittleEndian)
            {
                Array.Reverse(tickBytes);
            }

            var bytes = Guid.NewGuid().ToByteArray();

            bytes[08] = tickBytes[1];
            bytes[09] = tickBytes[0];
            bytes[10] = tickBytes[7];
            bytes[11] = tickBytes[6];
            bytes[12] = tickBytes[5];
            bytes[13] = tickBytes[4];
            bytes[14] = tickBytes[3];
            bytes[15] = tickBytes[2];

            return new Guid(bytes);
        }
    }
}