using System;

namespace _07_RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int times = int.Parse(Console.ReadLine());
            Result(input, times);  
        }

        static void Result (string input, int times)
        {
            for (int i = 0; i < times; i++)
            {
                Console.Write(input);
            }
        }
    }
}
