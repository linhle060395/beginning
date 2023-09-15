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
            Console.WriteLine("Give me a number between 0 and 100");
            int number = Convert.ToInt32(Console.ReadLine());

            Random random = new Random();
            int NumbertoGuess = random.Next(0, 101);
            Console.WriteLine($"The Number to Guess is {NumbertoGuess}");

           if(number == NumbertoGuess)
           {
                Console.WriteLine("You win!");
           }
           else if(number < NumbertoGuess)
           {
                Console.WriteLine("The Number to Guess is larger than your number");
           }
           else
           {
                Console.WriteLine("The Number to Guess is smaller than your number");
           }     
        }
    }
}