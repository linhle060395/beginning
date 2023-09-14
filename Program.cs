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
            string myText = "uuuuuUUUgGGhfdkajfwGGUU";
            string myText2 = myText.Replace("U", "G");
            myText2 = myText.Replace("u", "g");

            Console.WriteLine(myText2);   
        }
    }
}
