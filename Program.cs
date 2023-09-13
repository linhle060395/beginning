using System.Globalization;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myNumberList = new List<int>();
            
            Console.WriteLine("Sage mir wie viele Zahlen du in deine Liste hinzugügen möchtest");
            int amountNumbers = Convert.ToInt32(Console.ReadLine());

            while(myNumberList.Count < amountNumbers)
            {
                Console.WriteLine("Gebe mir eine Zahl");
                myNumberList.Add(Convert.ToInt32(Console.ReadLine()));
            }

            //Summiere alle zahlen auf
            int ergebnis = 0;
            foreach(int zahl in myNumberList)
            {
                ergebnis += zahl;
            }
            Console.WriteLine($"Das Ergebnis ist {ergebnis}");
      
        }
    
        }

    }
