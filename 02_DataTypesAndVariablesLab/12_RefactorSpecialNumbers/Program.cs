using System;

namespace _12_RefactorSpecialNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int kolkko = int.Parse(Console.ReadLine());
            //int obshto = 0;
            // int takova = 0;
            // bool toe = false;
            // for (int ch = 1; ch <= kolkko; ch++)
            // {
            //     takova = ch;
            //     while (ch > 0)
            //     {
            //         obshto += ch % 10;
            //        ch = ch / 10;
            //     }
            //     toe = (obshto == 5) || (obshto == 7) || (obshto == 11);
            //     Console.WriteLine("{0} -> {1}", takova, toe);
            //     obshto = 0;
            //     ch = takova;
            // }

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int sumOfDigits = 0;
                int digits = i;
                while (digits > 0)
                {
                    sumOfDigits += digits % 10;
                    digits/=10;
                }

                if (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }

        }
    }
}
