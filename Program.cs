using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Xml.XPath;
using Microsoft.VisualBasic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me the first number");
            int number1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Give me the second number");
            int number2 = Convert.ToInt16(Console.ReadLine());

            int result = number1 % number2;
                Console.WriteLine($"The calculation is {result}");
        }
    }
}