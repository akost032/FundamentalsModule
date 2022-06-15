using System;

namespace _09_GreaterOfTwoValues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    int firstInt = int.Parse(Console.ReadLine());
                    int secondInt = int.Parse(Console.ReadLine());
                    GetMax(firstInt, secondInt);
                    break;
                case "char":
                    char firstChar = char.Parse(Console.ReadLine());
                    char secondChar = char.Parse(Console.ReadLine());
                    GetMax(firstChar, secondChar);
                    break;
                case "string":
                    string firstString = Console.ReadLine();
                    string secondString = Console.ReadLine();
                    GetMax(firstString, secondString);
                    break;
                default:
                    break;
            }

        }

        static void GetMax(int first, int second)
        {
            if (first>second)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
        }

        static void GetMax(char first, char second)
        {
            if (first > second)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
        }

        static void GetMax(string first, string second)
        {
            int result = first.CompareTo(second);
            if (result>0)
            {
                Console.WriteLine(first);
            }
            else
            {
                Console.WriteLine(second);
            }
        }


    }
}
