using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
          //Frage den Nutzer nach der ersten Zahl
          Console.WriteLine("Gebe mir der ersten Zahl");
          string Zahl1 = Console.ReadLine();

          //Fragen den Nutzer nach der zweiten Zahl
          Console.WriteLine("Gebe mir der zweiten Zahl");
          string Zahl2 = Console.ReadLine();


          //Gebe das Ergebnis auf der Console aus
          //"Das Ergebnis aus {{Zahl1}} + {{Zahl2}} = {{Ergebnis}}
          int Zahl1int = Convert.ToInt16(Zahl1);
          int Zahl2int = Convert.ToInt16(Zahl2);
          int Ergebnis = Zahl1int + Zahl2int;
          Console.WriteLine($"Das Ergebnis aus {Zahl1int} + {Zahl2int} = {Ergebnis}");
        }

    }
}