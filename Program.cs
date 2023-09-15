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
                    Addition(zahl1, zahl2);
                    break;
                case "-":
                    Substract(zahl1, zahl2);
                    break;
                case "*":
                    Multiply(zahl1, zahl2);
                    break;
                case "/":
                    Division(zahl1, zahl2);
                    break;
                default:
                    Console.WriteLine("Ich kenne diesen Operator nicht");
                    break;
            }
        }
    

        static void Addition(int number1, int number2)
        {
            Console.WriteLine(number1 + number2);
        }

        static void Substract(int number1, int number2)
        {
            Console.WriteLine(number1 - number2);
        }

        static void Multiply(int number1, int number2)
        {
            Console.WriteLine(number1 * number2);
        }

        static void Division(int number1, int number2)
        {
            Console.WriteLine(number1 / number2);
        }

    }
}