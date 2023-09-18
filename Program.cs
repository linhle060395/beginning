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
           Console.WriteLine("Wie viele Zahlen möchtest du in einem Array?");
           string eingabe = Console.ReadLine();
           int groese = Convert.ToInt16(eingabe);

           int[] myArray = new int[groese];
           
           for(int position = 0; position < myArray.Length; position++)
           {
                string texteingeben = Console.ReadLine();
                myArray[position] = Convert.ToInt16(texteingeben);
           }
           
           int max = myArray.Max();
           int min = myArray.Min();
           double average = myArray.Average();
           
           Console.WriteLine($"Die größte Zahl ist {max}");
           Console.WriteLine($"Die kleinste Zahl ist {min} ");
           Console.WriteLine($"Durschnitt ist {average}");
        }
    }
}
