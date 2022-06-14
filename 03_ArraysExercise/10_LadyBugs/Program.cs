using System;

namespace _10_LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int filedSize = int.Parse(Console.ReadLine());
            int[] ladyBugsField = new int[filedSize];

            string [] occupiedIndexes = Console.ReadLine().Split(" ");

            for (int i = 0; i < occupiedIndexes.Length; i++)
            {
                int currIndex = int.Parse(occupiedIndexes[i]);

                if (currIndex>=0&&currIndex<filedSize)
                {
                    ladyBugsField[currIndex] = 1;
                }
            }

            string[] commands = Console.ReadLine().Split(" ");

            while (commands[0]!="end")
            {
                bool isFirst = true;
                int currIndex = int.Parse(commands[0]);

                while (currIndex >= 0 && currIndex < filedSize && ladyBugsField[currIndex] !=0)
                {
                    if (isFirst)
                    {
                        ladyBugsField[currIndex] = 0;
                        isFirst = false;
                    }

                    string direction = commands[1];
                    int flightLenght = int.Parse(commands[2]);
                    if (direction== "left")
                    {
                        currIndex -= flightLenght;
                        if (currIndex >= 0&&currIndex<filedSize)
                        {
                            if (ladyBugsField[currIndex]==0)
                            {
                                ladyBugsField[currIndex] = 1;
                                break;
                            }
                        }
                    }
                    else
                    {
                        currIndex+=flightLenght;
                        if (currIndex >= 0&&currIndex<filedSize)
                        {
                            if (ladyBugsField[currIndex]==0)
                            {
                                ladyBugsField[currIndex] = 1;
                                break;
                            }
                        }
                    }

                }
                commands = Console.ReadLine().Split(" ");
            }

            Console.WriteLine(string.Join(" ",ladyBugsField));
        }
    }
}
