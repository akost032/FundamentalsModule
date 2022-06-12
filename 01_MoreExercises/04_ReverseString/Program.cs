using System;

namespace _04_ReverseString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            char[] inputs = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                inputs[i] = input[i];
            }

            Array.Reverse(inputs);
            foreach (char letter in inputs)
            {
                Console.Write(letter);
            }
        }
    }
}
