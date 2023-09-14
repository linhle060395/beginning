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
            Console.WriteLine("Enter a text");
            string text = Console.ReadLine();

            int countOfLetterA = text.Count(c => c == 'a' || c == 'A');

        Console.WriteLine($"The letter 'a' occurs {countOfLetterA} times in the text.");
        }
    }
}