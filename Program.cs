using System.Globalization;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Gebe mir deinen Namen!");
           string name = Console.ReadLine();

           if(name.Length > 5)
           {
                Console.WriteLine("Oh der Name ist aber lang");
           }
           else
           {
                Console.WriteLine("Der ist ja kurz");
           }
        }

    }
}