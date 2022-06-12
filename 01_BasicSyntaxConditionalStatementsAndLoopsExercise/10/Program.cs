using System;

namespace _10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGames = int.Parse(Console.ReadLine());
            double headseatPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadsets = 0;
            int trashedMouses = 0;
            int trashedKeyboards = 0;
            int trashedDisplays = 0;
            
            for (int i = 1; i <= lostGames; i++)
            {
                if (i%2==0)
                {
                    trashedHeadsets++;
                }
                if (i%3==0)
                {
                    trashedMouses++;
                }
                if (i%2==0&&i%3==0)
                {
                    trashedKeyboards++;
                    if (trashedKeyboards%2==0)
                    {
                        trashedDisplays++;
                    }
                }
            }
            Console.WriteLine($"Rage expenses: {(trashedHeadsets*headseatPrice)+(trashedMouses*mousePrice)+(trashedKeyboards*keyboardPrice)+(trashedDisplays*displayPrice):F2} lv.");
        }
    }
}
