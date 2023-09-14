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
            Console.WriteLine("Give me a number");
            int number = Convert.ToInt16(Console.ReadLine());

            for(int i=1; i<number; i++)
            {
                if(i%3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if(i%5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if(i%3 == 0 && i%5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}