using System;
using System.Linq;

namespace _09_KaminoFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int seqenceLength = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int[] DNA = new int[seqenceLength];
            int DNASum = 0;
            int DNACount = -1;
            int DNAStartIndex = -1;
            int DNASamples = 0;
            int sample = 0;

            while (input!="Clone them!")
            {
                sample++;
                int[] currDNA = input.Split("!", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int currCount = 0;
                int currStartIndex = 0;
                int currEndIndex = 0;
                int currDNASum = 0;
                bool isCurrDNABetter = false;

                int count = 0;

                for (int i = 0; i < currDNA.Length; i++)
                {
                    if (currDNA[i]!=1)
                    {
                        count = 0;
                        continue;
                    }
                    count++;
                    if (count>currCount)
                    {
                        currCount = count;
                        currEndIndex= i;
                    }
                }
                currStartIndex=currEndIndex-currCount+1;
                currDNASum = currDNA.Sum();

                if (currCount>DNACount)
                {
                    isCurrDNABetter = true;
                }
                else if (currCount==DNACount)
                {
                    if (currStartIndex<DNAStartIndex)
                    {
                        isCurrDNABetter = true;
                    }
                    else if (currStartIndex==DNAStartIndex)
                    {
                        if (currDNASum>DNASum)
                        {
                            isCurrDNABetter = true;
                        }

                    }
                }
                if (isCurrDNABetter)
                {
                    DNA = currDNA;
                    DNACount=currCount;
                    DNAStartIndex = currStartIndex;
                    DNASum = currDNASum;
                    DNASamples = sample;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {DNASamples} with sum: {DNASum}.");
            Console.WriteLine(string.Join(" ",DNA));
        }
    }
}
