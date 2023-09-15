using System.ComponentModel;
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
           Console.WriteLine("How many texts do you want in an array?");
           int number = Convert.ToInt16(Console.ReadLine());

           string[] theArray = new string[number];

           for(int i=0; i < number; i++)
           {
                string text1 = Console.ReadLine();
                theArray[i] = text1;
           }

           foreach(string entry in theArray)
           {
                Console.WriteLine(entry.PadLeft(20,' '));
           }
           
        }
    }
}