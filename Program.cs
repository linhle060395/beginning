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

            // Split the input using semicolon as the delimiter
        string[] values = text.Split(';');

        Console.WriteLine("Individual values:");

        // Output each individual value
        foreach (string value in values)
        {
            Console.WriteLine(value.Trim()); // Trim to remove leading/trailing spaces
        }
        }
    }
}