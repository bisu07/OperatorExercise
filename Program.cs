using System;

namespace operatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 15;
            int num2 = 6;
            var addition = num1 + num2;
            var subtraction = num1 - num2;
            var quotient = num1 / num2;
            var remainder = num1 % num2;
            Console.WriteLine($"The result of {num1}/{num2} is {quotient} amd remainder is {remainder}");

        }
    }
}
