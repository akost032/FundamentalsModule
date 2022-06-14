using System;
using System.Linq;

namespace _01_Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A train has n number of wagons (integer, received as input). On the next n lines, you will receive the number of 
            //people that are going to get on each wagon. Print out the number of passengers in each wagon followed by the 
            //total number of passengers on the train.

            int numbersOfWagons = int.Parse(Console.ReadLine());
            int[] wagons = new int[numbersOfWagons];
            int sum = 0;


            for (int i = 0; i < wagons.Length; i++)
            {
                wagons[i] = int.Parse(Console.ReadLine());
                sum+= wagons[i];
            }

            foreach (int wagon in wagons)
            {
                Console.Write($"{wagon} ");
            }


            Console.WriteLine("");
            Console.WriteLine(sum);


        }
    }
}


