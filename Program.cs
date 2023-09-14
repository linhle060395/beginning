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
            Console.WriteLine("Gebe mir ein Zahl");
            int Zahl = Convert.ToInt16(Console.ReadLine());

            for(int i = 0; i <= Zahl; i++)
            {
                Console.WriteLine(i);
            }            
        }
    }
}
