﻿using System;

namespace _02_PoundsToDollars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pounds = double.Parse(Console.ReadLine());
            double dollars = pounds * 1.31;

            Console.WriteLine($"{dollars:f3}");
        }
    }
}
