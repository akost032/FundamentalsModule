using System;

namespace _06_CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double height = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double area = RectangleArea(height, width);
            Console.WriteLine(area);
        }

        static double RectangleArea(double height, double width)
        {
            return height * width;
        }
    }
}
