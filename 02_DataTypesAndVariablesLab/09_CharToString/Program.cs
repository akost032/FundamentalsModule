using System;

namespace _09_CharToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());

            string result = $"{a}{b}{c}";
            Console.WriteLine(result);
        }
    }
}
