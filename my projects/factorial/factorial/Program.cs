// See https://aka.ms/new-console-template for more information
using System;
class Program
{
    static void Main()
    {
        int n;
        long factorial = 1;

        Console.Write("Enter  a number:");
        n = int.Parse(Console.ReadLine());
        for(int i = 1; i <=n; i++)
        {
            factorial = factorial * i;
        }
        Console.WriteLine("Factorial of" + n + "is " + factorial);
        Console.ReadLine();
    }
}
