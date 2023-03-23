using System.ComponentModel.Design;
using System.Xml;

namespace TLsaPPurePuzzles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            bool reverse = false;
            int totalLength = 4;
            bool cross = false;

            TriangleWrite(length, reverse, totalLength, cross);
            DiamondWrite(length, reverse, totalLength, cross);
            CrossWrite(length, reverse, totalLength, cross);

        }

        private static void CrossWrite(int length, bool reverse, int totalLength, bool cross)
        {
            reverse = !reverse;
            length = 0;
            cross = !cross;
            WriteLineDecreasing(length, reverse, totalLength, cross);
        }

        private static void DiamondWrite(int length, bool reverse, int totalLength, bool cross)
        {
            reverse = !reverse;
            length = 0;
            WriteLineDecreasing(length, reverse, totalLength, cross);
        }

        private static void TriangleWrite(int length, bool reverse, int totalLength, bool cross)
        {
            length = 4;

            WriteLineDecreasing(length, reverse, totalLength, cross);
        }

        private static void WriteLineDecreasing(int length, bool reverse, int totalLength, bool cross)
        {

            if (!reverse)
            {
                if (cross)
                {
                    UpsideDownLast(length, totalLength, cross);
                    UpsideDownFirst(length, totalLength, cross);
                }
                else
                {
                    UpsideDownFirst(length, totalLength);
                    UpsideDownLast(length, totalLength);
                }

                length--;
                Console.WriteLine();
                if (length < 0) return;
            }
            else
            {
                if (cross)
                {
                    UpsideDownLast(length, totalLength, cross);
                    UpsideDownFirst(length, totalLength, cross);
                }
                else
                {
                    UpsideDownFirst(length, totalLength);
                    UpsideDownLast(length, totalLength);
                }
                length++;
                Console.WriteLine();
                if (length > totalLength)
                {
                    reverse = !reverse;
                    length = totalLength;
                }
            }

            WriteLineDecreasing(length, reverse, totalLength, cross);
        }

        private static void UpsideDownFirst(int length, int totalLength)
        {
            for (int i = totalLength; i >= 0; i--)
            {
                if (i < length) WriteHash();
                else WriteSpace();
            }
        }

        private static void UpsideDownLast(int length, int totalLength)
        {
            for (int i = 0; i < totalLength; i++)
            {
                if (i < length) WriteHash();
                else WriteSpace();
            }
        }

        private static void UpsideDownFirst(int length, int totalLength, bool cross)
        {
            if (cross)
            {
                int j = length;
                for (int i = totalLength; i >= 0; i--)
                {
                    if (i < length) WriteHash();
                    else
                    {
                        if (i > length) WriteSpace();
                        if (j < length + 1 && length != totalLength)
                        {
                            WriteSpace();
                        }
                    }

                    j--;
                }
                

            }
        }

        private static void UpsideDownLast(int length, int totalLength, bool cross)
        {
            if (cross)
            {
                int k = 0;
                for (int j = 0; j < length; j++) WriteSpace();
                for (int i = 0; i < totalLength; i++)
                {
                    if (i < length) WriteHash();
                    else WriteSpace();
                    if (k > length) WriteSpace();
                    k++;

                }

            }
        }
        private static void WriteHash()
        {
            Console.Write('#');
        }
        private static void WriteSpace()
        {
            Console.Write(' ');
        }

        //private static void WriteTriangle(int length, bool reverse)
        //{
        //    length = 4;
        //    reverse = false;
        //    bool[] writeOrNot = new bool[length];

        //    do
        //    {
        //        length = WriteResult(length, reverse, writeOrNot);
        //    } while (length >= 0);
        //}

        //private static int WriteResult(int length, bool reverse, bool[] writeOrNot)
        //{
        //    //int i = 0;
        //    writeOrNot = SetWrite(length, writeOrNot);
        //    //do
        //    //{
        //    //    foreach (var point in writeOrNot)
        //    //    {
        //    //        if (point) WriteHash();
        //    //        else WriteSpace();
        //    //    }

        //    //    if (i == writeOrNot.Length) reverse = true;
        //    //    if (!reverse) i++;
        //    //    else i--;
        //    //} while (i >= 0);
        //    for (int i = writeOrNot.Length - 1; i >= 0; i--)
        //    {
        //        if (writeOrNot[i])
        //        {
        //            WriteHash();
        //        }
        //        else WriteSpace();
        //    }
        //    for (int i = 0; i < writeOrNot.Length; i++)
        //    {
        //        if (writeOrNot[i])
        //        {
        //            WriteHash();
        //        }
        //        else WriteSpace();
        //    }
        //    Console.WriteLine();

        //    length--;
        //    return length;

        //}

        //private static bool[] SetWrite(int length, bool[] writeOrNot)
        //{
        //    int totalLength = writeOrNot.Length;
        //    for (int i = 0; i < totalLength; i++)
        //    {
        //        if (i < length)
        //        {
        //            writeOrNot[i] = true;
        //        }
        //        else
        //        {
        //            writeOrNot[i] = false;
        //        }
        //    }
        //    return writeOrNot;
        //}

        ////private static void WriteTest(int rounds)
        ////{
        ////    for (int i = 0; i < rounds; i++)
        ////    {
        ////        WriteHash();
        ////    }
        ////    Console.WriteLine();

        ////    rounds--;
        ////    if (rounds == 0) return;
        ////    WriteTest(rounds);
        ////}


        ////private static void WriteTriangle(int i)
        ////{
        ////    i = 0;


        ////    do
        ////    {


        ////    } while (i > 0);
        ////}
    }

}