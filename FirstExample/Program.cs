using System;

class Recursion
{
   static void Main()
   {
        Console.Write("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        int result = Factorial(number);
        Console.WriteLine($"Factorial of {number} is: {result}");
    }
    static int Factorial(int n)
    {
        return (n <= 1) ? 1 : n * Factorial(n - 1);
    }
}