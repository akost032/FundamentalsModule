using System;
using System.Linq;

namespace _07_MaxSequenceOfEqualElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int longestSeqLength = 1;
            int longestSeqStart = 0;
            int currentSqLength = 1;
            int currentSqStart = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i-1])
                {
                    currentSqLength++;
                    if (currentSqLength>longestSeqLength)
                    {
                        longestSeqLength = currentSqLength;
                        longestSeqStart = currentSqStart;
                    }
                }
                else
                {
                    currentSqLength = 1;
                    currentSqStart = i;
                }
            }

            for (int i = longestSeqStart; i <longestSeqStart+longestSeqLength; i++)
            {
                Console.Write(numbers[i] + " ");
            }

        }
    }
}
