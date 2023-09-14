using System.Globalization;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe mir der ersten Nummer");
            string Eingabe1 = Console.ReadLine();

            Console.WriteLine("Gebe mir der zweiten Nummer");
            string Eingabe2 = Console.ReadLine();

            int Nummer1 = Convert.ToInt16(Eingabe1);
            int Nummer2 = Convert.ToInt16(Eingabe2);
            int Ergebnis = Nummer1 + Nummer2;
            Console.WriteLine("Die Summe von 2 Nummer ist " + Ergebnis);
        }
    }
}