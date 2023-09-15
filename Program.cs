using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string operators = " ";
            do
            {
                Console.WriteLine("Gebe mir ein Rechenzeichen (+,-,*,/)");
                operators = Console.ReadLine();
            }
            while(operators != "+" && operators != "-" && operators != "*" && operators != "/");

            Console.WriteLine("Geschafft");

            int zahl1 = 16;
            int zahl2 = 32;

            switch(operators)
            {
                case "+":
                    Console.WriteLine(zahl1 + zahl2);
                    break;
                case "-":
                    Console.WriteLine(zahl1 - zahl2);
                    break;
                case "*":
                    Console.WriteLine(zahl1 * zahl2);
                    break;
                case "/":
                    Console.WriteLine(zahl1 / zahl2);
                    break;
                default:
                    Console.WriteLine("Ich kenne diesen Operator nicht");
                    break;
            }
        }
    

        static void Addition(int zahl1, int zahl2)
        {
            Console.WriteLine(zahl1 + zahl2);
        }

        static void Substract(int zahl1, int zahl2)
        {
            Console.WriteLine(zahl1 - zahl2);
        }

        static void Multiply(int zahl1, int zahl2)
        {
            Console.WriteLine(zahl1 * zahl2);
        }

        static void Division(int zahl1, int zahl2)
        {
            Console.WriteLine(zahl1 / zahl2);
        }

    }
}