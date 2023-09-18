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
            Console.WriteLine("Bitte schreiben Sie einen Text");
            string Text = Console.ReadLine();

            int length = Text.Length;
            Console.WriteLine($"Die Länge des Textes ist {length}");

            //Möglichkeit 1:
            string [] splittedText = Text.Split('h');

            //Möglichkeit 2a:
            for(int i = 0; i<splittedText.Length; i++)
            {
                if(Text[i] == 'h')
                {
                    count++;
                }
            Console.WriteLine($"Es gibt {count} h's in Seinem Text");
            }

            //Möglichkeit 2b:
            foreach(char c in Text)
            {
                if(c == 'h')
                {
                    count++;
                }
            }

             //Möglichkeit 3:
           int numberofh = Text.Count(c => c == 'h');
           Console.WriteLine($"Es gibt {numberofh} h's in Seinem Text.");
        }
    }
}
