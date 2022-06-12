using System;

namespace _09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double lightSaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double total = 0;

            double lightSaberTotal = lightSaberPrice * (Math.Ceiling(students * 1.10));
            double robeTotal = robePrice * students;
            double beltsPrice = beltPrice * students;
            int beltDiscount = students / 6;
            double totalDiscount = beltPrice * beltDiscount;
            double beltTotal = beltsPrice - totalDiscount;

            total = lightSaberTotal + robeTotal + beltTotal;

            if (budget >= total)
            {
                Console.WriteLine($"The money is enough - it would cost {total:F2}lv.");
            }
            else
            {
                Console.WriteLine($" John will need {(total-budget):F2}lv more.");
            }

        }
    }
}
