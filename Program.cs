using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
          //Frage den Nutzer nach der ersten Zahl
         Console.WriteLine("Gebe mir der ersten Zahl");
         string eingabe1 = Console.ReadLine();
          

          //Fragen den Nutzer nach der zweiten Zahl
          Console.WriteLine("Gebe mir der zweiten Zahl");
          string eingabe2 = Console.ReadLine();


          //Gebe das Ergebnis auf der Console aus
          //"Das Ergebnis aus {{Zahl1}} - {{Zahl2}} = {{Ergebnis}}
          int Zahl1 = Convert.ToInt16(eingabe1);
          int Zahl2 = Convert.ToInt16(eingabe2);
          int Ergebnis = Zahl1 - Zahl2;
          Console.WriteLine($"Das Ergebnis aus {Zahl1} - {Zahl2} = {Ergebnis}");
        }

    }
}