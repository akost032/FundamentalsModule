using System;

namespace _05_PrintPartOfTheASCIITable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int beginning = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int i = beginning; i <= end; i++)
            {
                Console.Write((Char)i);
                Console.Write(" ");
            }
        }
    }
}
