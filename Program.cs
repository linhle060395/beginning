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

            string uppertext = text.ToUpper();

            Console.WriteLine($"{uppertext}");
        }
    }
}