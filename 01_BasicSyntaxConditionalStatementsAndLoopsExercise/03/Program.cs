using System;

namespace _03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfArrival = Console.ReadLine();
            double pricePerPerson = 0;
            double total = 0;
            double finalPrice = 0;

            switch (dayOfArrival)
            {
                case "Friday":
                    if (typeOfGroup=="Students")
                    {
                        pricePerPerson = 8.45;
                    }
                    else if (typeOfGroup=="Business")
                    {
                        pricePerPerson = 10.90;
                    }
                    else if (typeOfGroup=="Regular")
                    {
                        pricePerPerson = 15;
                    }
                    break;
                case "Saturday":
                    if (typeOfGroup == "Students")
                    {
                        pricePerPerson = 9.80;
                    }
                    else if (typeOfGroup == "Business")
                    {
                        pricePerPerson = 15.60;
                    }
                    else if (typeOfGroup == "Regular")
                    {
                        pricePerPerson = 20;
                    }
                    break;
                case "Sunday":
                    if (typeOfGroup == "Students")
                    {
                        pricePerPerson = 10.46;
                    }
                    else if (typeOfGroup == "Business")
                    {
                        pricePerPerson = 16;
                    }
                    else if (typeOfGroup == "Regular")
                    {
                        pricePerPerson = 22.50;
                    }
                    break;
                default:
                    break;
            }

            total = countOfPeople * pricePerPerson;

            if (typeOfGroup=="Students"&&countOfPeople>=30)
            {
                finalPrice = total - (total * 0.15);
                Console.WriteLine($"Total price: {finalPrice:f2}");
            }
            else if (typeOfGroup=="Business"&&countOfPeople>=100)
            {
                finalPrice = total - (10 * pricePerPerson);
                Console.WriteLine($"Total price: {finalPrice:f2}");
            }
            else if (typeOfGroup=="Regular"&&countOfPeople>=10&&countOfPeople<=20)
            {
                finalPrice = total - (total * 0.05);
                Console.WriteLine($"Total price: {finalPrice:f2}");
            }
            else
            {
                Console.WriteLine($"Total price: {total:f2}");
            }
        }
    }
}
