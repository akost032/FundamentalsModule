using System;

namespace _07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfDay = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            int price = 0;

            if (age<0)
            {
                Console.WriteLine("Error!");
            }
            switch (typeOfDay)
            {
                case "Weekday":
                    if (age>=0&&age<=18||age>64&&age<=122)
                    {
                        price = 12;
                        Console.WriteLine($"{price}$");
                    }
                    else if (age>18&&age<=64)
                    {
                        price = 18;
                        Console.WriteLine($"{price}$");
                    }
                    break;
                case "Weekend":
                    if (age>=0&&age<=18||age>64&&age<=122)
                    {
                        price = 15;
                        Console.WriteLine($"{price}$");
                    }
                    else if (age>18&&age<=64)
                    {
                        price = 20;
                        Console.WriteLine($"{price}$");
                    }
                    break;
                case "Holiday":
                    if (age>=0&&age<=18)
                    {
                        price = 5;
                        Console.WriteLine($"{price}$");
                    }
                    else if (age >18&&age<=64)
                    {
                        price = 12;
                        Console.WriteLine($"{price}$");
                    }
                    else if (age >64&&age<=122)
                    {
                        price = 10;
                        Console.WriteLine($"{price}$");
                    }
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }
        }
    }
}
