using System;

namespace _11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfOrders = int.Parse(Console.ReadLine());
            double total = 0;
            for (int i = 1; i <=countOfOrders; i++)
            {
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                double orderPrice = ((days * capsulesCount) * pricePerCapsule);
                total += orderPrice;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:F2}");
            }
            Console.WriteLine($"Total: ${total:F2}");

        }
    }
}
