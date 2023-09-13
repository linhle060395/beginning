using System.Globalization;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
{
        //Frage den Nutzer bis zu welcher Zahl aufsummiert werden soll
       
        //Mache das in allen möglichen Schleifenarten
        //In welcher geht es nicht und wieso?
            //for, foreach, while, do while
       
       List<int> myNumberList = new List<int>();
       
       Console.WriteLine("Bis zu welcher Zahl soll aufsummiert werden?");
       int untilNumber = Convert.ToInt32(Console.ReadLine());

       int i = 0;
       int zahl = 0;
       int ergebnis = 0;

       while(i<untilNumber)
       {
            zahl = i + 1;
            ergebnis += zahl;
            Console.WriteLine($"Added number {i}, current result {ergebnis}");
            i++;
       }       
       
    }
}
}
            