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
           Console.WriteLine("Bitte geben eine Zahl");
           int Zahl = Convert.ToInt32(Console.ReadLine());

           for(int i = Zahl; i >= 0 ; i-=2)

           {
                Console.WriteLine(i);
           }

           //Möglichkeit 2:

           while(Zahl>0)
           {
                Console.WriteLine(Zahl);
                Zahl = Zahl - 2;
           }
        }
    }
}
