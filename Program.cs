using System.Collections;
using System.Collections.Immutable;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Transactions;
using System.Xml.XPath;
using Microsoft.VisualBasic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Erstelle für folgende Berechnungen jeweils eine Methode
        -   Berechnung des Umfangs von einem Kreis. Überlege welche Parameter du benötigst und welchen Typ als Rückgabewert gebraucht wird.
        -   Berechne den Umfang eines Quadrats.
        -   Berechne de Umfang eines Rechtecks => Was ist der Unterschied?
        -   Berechne das Volumen eines Würfels
        -   Berechne das Volumen eines Quaders.
            */
        // Berechnung des Umfangs von einem Kreis. Überlege welche Parameter du benötigst und welchen Typ als Rückgabewert gebraucht wird.
        Console.WriteLine("Gebe mir den Radius");
        int Radius = Convert.ToInt16(Console.ReadLine());
        double Umfang = 2 * Math.PI * Radius;
        Console.WriteLine($"Der Umfang eines Kreises ist {Umfang}");
        

        // Berechne den Umfang eines Quadrats.
        Console.WriteLine("Gebe mir die Kantenlänge des Quadrats");
        int Kante = Convert.ToInt16(Console.ReadLine());
        int Umfang2 = 4 * Kante;
        Console.WriteLine($"Der Umfang eines Quadrats ist {Umfang2}");


        // Berechne den Umfang eines Rechtecks
        Console.WriteLine("Gebe mir die Länge des Rechtecks");
        int Länge = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Gebe mir die Breite des Rechtecks");
        int Breite = Convert.ToInt16(Console.ReadLine());
        int Umfang3 = 2 * (Länge + Breite);
        Console.WriteLine($"Der Umfang eines Rechtecks ist {Umfang3}");


        // Berechne das Volumen eines Würfels
        Console.WriteLine("Gebe mir die Kantenlänge des Quadrats");
        int Kante2 = Convert.ToInt16(Console.ReadLine());
        double Volumen = Math.Pow (Kante2, 3);
        Console.WriteLine($"Das Volumen eines Würfels ist {Volumen}");


        // Berechne das Volumen eines Quaders
        Console.WriteLine("Gebe mir die Länge des Rechtecks");
        int Länge2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Gebe mir die Breite des Rechtecks");
        int Breite2 = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine("Gebe mir die Höhe des Rechtecks");
        int Höhe = Convert.ToInt16(Console.ReadLine());
        double Volumen2 = Länge2 * Breite2 * Höhe;
        Console.WriteLine($"Das Volumen eines Quaders ist {Volumen2}");
        }
    }
}
