using System;

namespace _02_SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string num = number.ToString();
            int sum = 0;
            int cn = number;

            for (int i = num.Length; i >=0 ; i--)
            {
                int currentNumber = 0;
                currentNumber=cn%10;
                cn=cn/10;
                sum += currentNumber;
            }

            Console.WriteLine(sum);
        }
    }
}
