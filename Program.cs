using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Net.NetworkInformation;
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
          /*
            // Passe die Methode "Fahren" so an, dass 
            //- bei einer Geschwindigkeit von 0 die Methode "steht" zurück gibt: Hinweis: return
            //- bei einer Geschwindigkeit von 1-10 "schleicht" zurück gibt
            //- bei einer Geschwindigkeit von 11-50 "fährt langsam" zurück gibt
            //- bei einer Geschwindigkeit von 51-100 "fährt schnell" zurück gibt
            //- bei einer Geschwindigkeit über 100 "rast" zurück gibt.

            //Bau die Ausgabe so, dass nach jedem Aufruf folgende Texte ausgegeben werden können. 
            //Das Auto steht.
            //Das Auto schleicht.
            //Das Auto fährt langsam.
            //Das Auto fährt schnell. 
            //Das Auto rast.
            */

            
            Console.WriteLine("Bitte eine Geschwindigkeit geben");
            int geschwindigkeit = Convert.ToInt16(Console.ReadLine());
            string ausgabe = Fahren(geschwindigkeit);


        static string Fahren(int geschwindigkeit)
        {
            if(geschwindigkeit == 0)
            {
                return "Das Auto steht";
            }

            else if(geschwindigkeit >= 1 && geschwindigkeit <= 10)
            {
                return "Das Auto schleicht";
            }

            else if(geschwindigkeit >= 11 && geschwindigkeit <= 50)
            {
                return "Das Auto fährt langsam";
            }

            else if(geschwindigkeit >= 51 && geschwindigkeit <= 100)
            {
                return "Das Auto fährt schnell";
            }
            
            else if(geschwindigkeit > 100)
            {
                return "Das Auto rast";
            }

            else
            {
                return "Fehlernummer";
            }
        }
        
        Console.WriteLine($"{ausgabe} mit {geschwindigkeit} km/h ");
        }
    }
}