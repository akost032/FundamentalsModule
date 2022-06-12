using System;

namespace _02_PrintNumbersinReverseOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            int[] nums = new int[numbers];

            for (int i = 0; i < numbers; i++)
            {
                int input = int.Parse(Console.ReadLine());
                nums[i] = input;
            }

            for (int i = numbers-1; i>=0; i--)
            {
                Console.Write(nums[i]+" ");
            }

        }
    }
}
