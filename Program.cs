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
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());

            int factorial = CalculateFactorial(number);

            Console.WriteLine($"The factorial of {number} ist {factorial}");
        }

        static int CalculateFactorial(int n)
        {
            if(n == 0)
                return 1;
            else    
                return n * CalculateFactorial(n - 1);
        }
    }
}