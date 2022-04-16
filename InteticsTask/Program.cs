using System;

namespace InteticsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var bufferToPrint = new char[512];
            int bufferToPrintCount = 0;
            var bufferToRead = new char[512];
            int bufferToReadCount;
            int charsToCopyLength;
            do
            {
                bufferToReadCount = GetData(out bufferToRead);
                if (bufferToReadCount != 0)
                {
                    charsToCopyLength = Math.Min(bufferToReadCount, bufferToPrint.Length - bufferToPrintCount);
                    Array.Copy(bufferToRead, 0, bufferToPrint, bufferToPrintCount, charsToCopyLength);
                    bufferToPrintCount += charsToCopyLength;
                    if (bufferToPrintCount == bufferToPrint.Length)
                    {
                        PutData(bufferToPrint, bufferToPrintCount);
                        bufferToPrintCount = 0;
                        if (bufferToReadCount > charsToCopyLength)
                        {
                            Array.Copy(bufferToRead, charsToCopyLength, bufferToPrint, 0, bufferToReadCount - charsToCopyLength);
                            bufferToPrintCount = bufferToReadCount - charsToCopyLength;
                        }
                    }
                }
            }
            while (bufferToReadCount != 0);
            if (bufferToPrintCount != 0)
            {
                PutData(bufferToPrint, bufferToPrintCount);
            }
        }

        private static int GetData(out char[] bufferToRead)
        {
            bufferToRead = new char[512];
            return 512;
        }

        private static void PutData(char[] bufferToPrint, int count)
        {
            Console.WriteLine("buffer To Print");
        }
    }
}
