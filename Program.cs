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

             if (text.Length >= 8)
        {
            string extractedSubstring = text.Substring(2, 5);
            Console.WriteLine($"Extracted Substring: {extractedSubstring}");
        }
        else
        {
            Console.WriteLine("The input text is too short. Please enter at least 8 characters.");
        }
        }
    }
}