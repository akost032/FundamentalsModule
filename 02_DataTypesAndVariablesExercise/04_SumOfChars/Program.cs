using System;

namespace _04_SumOfChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 1; i <=rows; i++)
            {
                string letter = Console.ReadLine();

                foreach (var item in letter)
                {
                    sum+=((int)item);
                }
            }

            Console.WriteLine($"The sum equals: {sum}");
        }
    }
}
