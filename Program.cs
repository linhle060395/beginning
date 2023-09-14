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
            string text = "hellothere";
            int desiredLength = 20;

            int yCount = desiredLength - text.Length;
            string yString = new string ('y', yCount);

            string result = yString + text;
            Console.WriteLine(result);
        }
    }
}