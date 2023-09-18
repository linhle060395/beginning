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
           //Der Nutzer soll eine Zahl eingeben. Diese stellen die Anzahl der Sekunden dar.
           //Konvertiere die Zahl in die Anzahl der Tage, Stunden, Minuten und restliche Sekunde
           //90061 ist ein Tag, eine Stunde, eine Minute, eine Sekunde.
           
           Console.WriteLine("Gebe mir die Anzahl der Sekunden");
           int Anzahl = Convert.ToInt32(Console.ReadLine());

           int Tage = Anzahl / (60*60*24);
           int Stunden = (Anzahl % (60 * 60 * 24)) / (60 * 60);
           int Minuten = ((Anzahl % (60 * 60 * 24)) % (60 * 60)) / 60;
           int Sekunden = ((Anzahl % (60 * 60 * 24)) % (60 * 60)) % 60;
           
           Console.WriteLine($"Tage: {Tage}");
           Console.WriteLine($"Stunden: {Stunden}");
           Console.WriteLine($"Minuten: {Minuten}");
           Console.WriteLine($"Sekunden: {Sekunden}");
        }
    }
}