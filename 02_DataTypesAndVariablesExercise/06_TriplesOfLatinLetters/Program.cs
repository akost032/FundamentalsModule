using System;

namespace _06_TriplesOfLatinLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            char firstChar;
            char secondChar;
            char thirdChar;

            for (int i = 0; i < input; i++)
            {
                firstChar = (char)('a' + i);
                for (int j = 0; j < input; j++)
                {
                    secondChar = (char)('a' + j);
                    for (int k = 0; k <input; k++)
                    {
                        thirdChar = (char)('a' + k);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
