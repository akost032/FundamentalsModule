using System;
using System.Linq;

namespace _06_EqualSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that determines if an element exists in an array for which the sum of all elements to its left
            //is equal to the sum of all elements to its right.
            //If there are no elements to the left or right, their sum is considered to be 0.
            //Print the index of the element that satisfies the condition or "no" if there is no such element.

            int[] numbers = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers.Length==1)
                {
                    Console.WriteLine(0);
                    return;
                }

                leftSum = 0;
                for (int sumLeft = i; sumLeft > 0; sumLeft--)
                {
                    int nextLeftElPoss = sumLeft - 1;
                    if (sumLeft>0)
                    {
                        leftSum += numbers[nextLeftElPoss];
                    }
                }
                rightSum = 0;
                for (int sumRigt = i; sumRigt < numbers.Length; sumRigt++)
                {
                    int nextElPoss = sumRigt + 1;
                    if (sumRigt<numbers.Length-1)
                    {
                        rightSum += numbers[nextElPoss];
                    }
                }

                if (rightSum==leftSum)
                {
                    Console.WriteLine(i);
                    return;
                }

            }

             Console.WriteLine("no");
             
        }
    }
}
