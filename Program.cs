using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
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
           Console.WriteLine("Bitte geben eine Zahl");
           int Zahl = Convert.ToInt32(Console.ReadLine());
           int fib1 = 1;
           int fib2 = 1;
           int ergebnis = 0;

           while(Zahl > (fib1 + fib2))
           {
                ergebnis = fib1 + fib2;
                Console.WriteLine($"Die Fibonacci Zahlen {fib1} + {fib2} = {ergebnis}");
                fib1 = fib2;
                fib2 = ergebnis;
           }
           
        }
    }
}
