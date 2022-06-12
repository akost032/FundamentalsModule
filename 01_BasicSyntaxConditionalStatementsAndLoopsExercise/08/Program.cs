using System;

namespace _08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write($"{i} ");
                }
                
                Console.WriteLine("");
            }
        }
    }
}
