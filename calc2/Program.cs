﻿namespace calc2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int sum = AddNumbers(num1, num2);
            Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
        }

        public static int AddNumbers(int a, int b)
        {
            return a + b;
        }
    }
}
