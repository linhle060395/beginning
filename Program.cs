using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

        if (number >= 0)
        {
            Console.WriteLine($"Counting down from {number} to 0:");
            for (int i = number; i >= 0; i--)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            Console.WriteLine("Please enter a non-negative number.");
        }
        }
    }
}