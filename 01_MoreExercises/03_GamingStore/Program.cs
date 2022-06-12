using System;

namespace _03_GamingStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double price = 0;
            double totalSpent = 0;

            while (input!="Game Time")
            {
                switch (input)
                {
                    case "OutFall 4":
                        price = 39.99;
                        break;
                    case "CS: OG":
                        price = 15.99;
                        break;
                    case "Zplinter Zell":
                        price = 19.99;
                        break;
                    case "Honored 2":
                        price = 59.99;
                        break;
                    case "RoverWatch":
                        price = 29.99;
                        break;
                    case "RoverWatch Origins Edition":
                        price = 39.99;
                        break;
                    default:
                        Console.WriteLine("Not Found");
                        break;
                }
                
                if (budget<price)
                {
                    Console.WriteLine("Too Expensive");
                }
                if (budget>=price)
                {
                    budget -= price;
                    totalSpent += price;
                    Console.WriteLine($"Bought {input}");
                }

                if (budget==0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${totalSpent:F2}. Remaining: ${budget:F2}");
        }
    }
}
