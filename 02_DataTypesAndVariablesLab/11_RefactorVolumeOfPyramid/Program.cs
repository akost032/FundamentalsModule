﻿using System;

namespace _11_RefactorVolumeOfPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //double dul, sh, V = 0;
            // Console.WriteLine("Length: ");
            //dul = double.Parse(Console.ReadLine());
            // Console.WriteLine("Width: ");
            //sh = double.Parse(Console.ReadLine());
            //Console.WriteLine("Heigth: ");
            //V = double.Parse(Console.ReadLine());
            //V = (dul + sh + V) / 3;
            //Console.WriteLine($"Pyramid Volume: {V:f2}");

            Console.Write("Length: ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());
            double areaOfTheBase = length * width;
            double volume = (areaOfTheBase * height) / 3;
            Console.WriteLine($"Pyramid Volume: {volume:f2}");

        }
    }
}
