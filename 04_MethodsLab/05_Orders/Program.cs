using System;

namespace _05_Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            OrderValue(input, quantity);
        }

        static void OrderValue (string input, double quantity)
        {
            switch (input)
            {
                case "coffee":
                    Console.WriteLine($"{(quantity*1.50):F2}");
                    break;
                case "water":
                    Console.WriteLine($"{(quantity*1.00):F2}");
                    break;
                case "coke":
                    Console.WriteLine($"{(quantity*1.40):F2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{(quantity*2.00):F2}");
                    break;
                default:
                    break;
            }
        }
    }
}
