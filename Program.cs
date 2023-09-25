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
            /*1.  Erstelle eine Liste von Integers welche 3 Elemente zum Start beinhaltet ( 5,3,7)
            2.  Füge der Liste weitere Zahlen hinzu. Der Nutzer soll in der
                Schleife selbst entscheiden ob er weitere hinzufügen möchte oder nicht
                (Leere Eingabe => Abbruch des Hinzufügens)
            3.  Gebe die Einträge der Liste in einer Schleife aus
            4.  Füge an Position 2 die Zahl 99 hinzu und gebe die Liste aus
            5.  Füge die Zahlen 91, 92, 93 gleichzeitig hinzu und gebe die Liste aus
            6.  Entferne das Element an der 1. Stelle und gebe die Liste aus
            7.  Entferne die Zahl 99 ohne zu wissen wo sie gerade steht und gebe die Liste aus
            8.  Lösche das Letzte Element der Liste und gebe die Liste aus
            9.  Schaue dir die Vorgeschlagenen Methoden von Listen an und probiere einige aus. (z.B. Sort, Reverse, )
            10. Lösche alle Zahlen größer als 80 und gebe die Liste aus
            */

            // 1. Erstelle eine Liste von Integers welche 3 Elemente zum Start beinhaltet ( 5,3,7)
            List<int> myIntegers = new List<int> ();

            Console.WriteLine("Gebe mir eine Liste den Zahlen mit 3,5,7");
            string Zahlen = Console.ReadLine();
            string[] numbers = Zahlen.Split(' ');
            foreach(string n in numbers)
            {
                myIntegers.Add(Convert.ToInt32(n));

            }
            
            // 2. Füge der Liste weitere Zahlen hinzu. Der Nutzer soll in der Schleife selbst entscheiden ob er weitere hinzufügen möchte oder nicht
            // 3. Gebe die Einträge der Liste in einer Schleife aus

            Console.WriteLine("Möchten Sie zusätzliche Zahlen hinzufügen? (Ja or Nein)");
            string eingabe = Console.ReadLine();

             if (eingabe == "Nein")
            {
                Console.WriteLine($"Die Liste der Nummern lautet {Zahlen}");
                
                foreach (int number in myIntegers)
                {
                    Console.WriteLine(number);
                }
            }
            else if (eingabe == "Ja")
            {
                
                Console.WriteLine("Gebe mir eine zusaätzliche Zahl");
                int input = Convert.ToInt32(Console.ReadLine());
                
                myIntegers.Add(input);
                Console.WriteLine($"Die neue Liste ist");
                foreach( int number in myIntegers)
                {
                    Console.WriteLine(number);
                }
            }

            // 4. Füge an Position 2 die Zahl 99 hinzu und gebe die Liste aus
            myIntegers.Insert(1,99);
            Console.WriteLine($"Die neue Liste ist:");
            foreach( int number in myIntegers)
            {
                Console.WriteLine(number);
            }
            
            // 5.  Füge die Zahlen 91, 92, 93 gleichzeitig hinzu und gebe die Liste aus
           myIntegers.AddRange(new int [] {91, 92, 93});
           Console.WriteLine($"Die neue Liste ist:");
            foreach( int number in myIntegers)
            {
                Console.WriteLine(number);
            }

            // 6.  Entferne das Element an der 1. Stelle und gebe die Liste aus
            myIntegers.RemoveAt(0);
            Console.WriteLine($"Die neue Liste ist:");
            foreach( int number in myIntegers)
            {
                Console.WriteLine(number);
            }

            // 7.  Entferne die Zahl 99 ohne zu wissen wo sie gerade steht und gebe die Liste aus
            myIntegers.Remove(99);
            Console.WriteLine($"Die neue Liste ist:");
            foreach( int number in myIntegers)
            {
                Console.WriteLine(number);
            }

           // 8.  Lösche das Letzte Element der Liste und gebe die Liste aus
           myIntegers.RemoveAt(myIntegers.Count - 1);
           Console.WriteLine($"Die neue Liste ist:");
            foreach( int number in myIntegers)
            {
                Console.WriteLine(number);
            }

            //  9.  Schaue dir die Vorgeschlagenen Methoden von Listen an und probiere einige aus. (z.B. Sort, Reverse, )
            myIntegers.Reverse();
            Console.WriteLine($"Die neue Liste ist:");
            foreach( int number in myIntegers)
            {
                Console.WriteLine(number);
            }

            // 10. Lösche alle Zahlen größer als 80 und gebe die Liste aus
            //myIntegers.RemoveAll(z => z > 80);

            for(int i = 0; i<myIntegers.Count; i++)
            {
                if(myIntegers[i]>80)
                {
                    myIntegers.RemoveAt(i);
                    i--;
                }
            }
            Console.WriteLine($"Die neue Liste ist:");
            foreach( int number in myIntegers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
