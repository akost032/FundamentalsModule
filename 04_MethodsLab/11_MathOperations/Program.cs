using System;

namespace _11_MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            int b = int.Parse(Console.ReadLine());
            Result(a, @operator, b);
        }

        static void Result (int a, string @operator, int b)
        {
            double result = 0;
            switch (@operator)
            {
                case "/":
                    result = (double)a / b;
                    Console.WriteLine(result);
                    break;
                case "*":
                    result = (double)a * b;
                    Console.WriteLine(result);
                    break;
                case "-":
                    result = (double)a - b;
                    Console.WriteLine(result);
                    break;
                case "+":
                    result = (double)a + b;
                    Console.WriteLine(result);
                    break;
                default:
                    break;
            }
        }
    }
}
