using System;

namespace _04_PrintingTrianlge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i <=input; i++)
            {
                PrintLine(1, i);
            }
            for (int i = input-1; i >0; i--)
            {
                PrintLine(1, i);
            }
        }

        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine(" ");
        }
    }
}
