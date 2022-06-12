using System;

namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double accumulated = 0;

            while (input != "Start")
            {
                double inputMoney = double.Parse(input);

                if (inputMoney == 0.1 || inputMoney == 0.2 || inputMoney == 0.5 || inputMoney == 1 || inputMoney == 2)
                {
                    accumulated += inputMoney;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {inputMoney}");
                }
                input = Console.ReadLine();
            }

            input= Console.ReadLine();

            while (input != "End")
            {
                double price = 0;

                if (input == "Nuts")
                {
                    price = 2;
                    if (accumulated >= price)
                    {
                        Console.WriteLine("Purchased nuts");
                        accumulated -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                if (input == "Water")
                {
                    price = 0.7;
                    if (accumulated >= price)
                    {
                        Console.WriteLine("Purchased water");
                        accumulated -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                if (input == "Crisps")
                {
                    price = 1.5;
                    if (accumulated >= price)
                    {
                        Console.WriteLine("Purchased crisps");
                        accumulated -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                if (input == "Soda")
                {
                    price = 0.8;
                    if (accumulated >= price)
                    {
                        Console.WriteLine("Purchased soda");
                        accumulated -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                if (input == "Coke")
                {
                    price = 1;
                    if (accumulated >= price)
                    {
                        Console.WriteLine("Purchased coke");
                        accumulated -= price;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                if(input!="Coke"&&input!="Soda"&&input!="Crisps"&&input!="Water"&&input!="Nuts")
                {
                    Console.WriteLine("Invalid product");
                }
                input=Console.ReadLine();
            }
            Console.WriteLine($"Change: {accumulated:f2}");
        }
    }       
}
