using System.Collections;
using System.Collections.Immutable;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Transactions;
using System.Xml.XPath;
using Microsoft.VisualBasic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe mir der ersten Zahl");
            int Zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Gebe mir der zweiten Zahl");
            int Zahl2 = Convert.ToInt32(Console.ReadLine());

            string Operation = " ";
            
          
            while(Operation != "+" && Operation != "-" && Operation != "*" && Operation != "/")
            {
                Console.WriteLine("Der Operanten ist: (+,-,*,/}"); 
                Operation = Console.ReadLine();
                
                switch(Operation)
                {
                    case "+": 
                    Console.WriteLine(Zahl1 + Zahl2);
                    break;

                    case "-":
                    Console.WriteLine(Zahl1 - Zahl2);
                    break;

                    case "*":
                    Console.WriteLine(Zahl1 * Zahl2);
                    break;

                    case "/":
                    Console.WriteLine(Zahl1 / Zahl2);
                    break;

                    default:
                    Console.WriteLine("Der Operanten ist nicht gültig.");
                    break;
                
                }
            }
            
        }
    }
}
