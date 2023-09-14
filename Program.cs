using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geb mir einen Text");
            string eingabe = Console.ReadLine();
            string str = "abc";
        
            Console.WriteLine(eingabe.Contains(str));
        }
    }
}