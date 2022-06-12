using System;

namespace _05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";
            int times = 0;

            for (int i =username.Length-1; i >= 0; i--)
            {
                password += username[i];
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input==password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                if (input != password)
                {
                    times++;
                    if (times >= 4)
                    {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                    }
                   
                    Console.WriteLine("Incorrect password. Try again.");
                }


            }
        }
    }
}
