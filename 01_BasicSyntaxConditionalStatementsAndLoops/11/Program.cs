using System;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            int multi = int.Parse(Console.ReadLine());

            if (multi <=10)
            {
                for (int times = multi; times <= 10; times++)
                {
                    int total = integer * times;
                    Console.WriteLine($"{integer} X {times} = {total}");
                }
            }
            else
            {
                int total = integer * multi;
                Console.WriteLine($"{integer} X {multi} = {total}");
            }
        }
    }
}
