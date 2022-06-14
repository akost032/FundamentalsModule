using System;
using System.Linq;

namespace _02_CommonElements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a program that prints out all common elements in two arrays. You have to compare the elements of the 
            //second array to the elements of the first.

            string[] firstArray = Console.ReadLine().Split(" ");
            string[] secondArray = Console.ReadLine().Split(" ");

            foreach (string currentElement in secondArray)
            {
                for (int i = 0; i < firstArray.Length; i++)
                {
                    string secondCurrentElement = firstArray[i];

                    if (secondCurrentElement==currentElement)
                    {
                        Console.Write($"{currentElement} ");
                    }
                }
            }
        }
    }
}
