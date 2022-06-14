using System;

namespace _03_Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double people = int.Parse(Console.ReadLine());
            double capacity = int.Parse(Console.ReadLine());

            if (capacity>people)
            {
                Console.WriteLine("1");
            }
            else
            {
                double roundedCourses = Math.Ceiling(people/capacity);
                Console.WriteLine(roundedCourses);
            }
        }
    }
}
