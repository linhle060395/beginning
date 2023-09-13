using System.Globalization;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)

        //Frage den Nutzer bis zu welcher Zahl aufsummiert werden soll


        //Mache das in allen möglichen Schleifenarten
        //In welcher geht es nicht und wieso?
            //for, foreach, while, do while
        {
            List<int> myNumberList = new List<int>();
            int user_zahl = 0;
            
            do
            {
                //code block
                Console.WriteLine("Gebe mir eine Zahl");
                user_zahl = Convert.ToInt32(Console.ReadLine());
                myNumberList.Add(user_zahl);
            } while(user_zahl > 0);

            //Summiere alle zahlen auf
            int ergebnis = 0;
            foreach(int zahl in myNumberList)
            {
                ergebnis = ergebnis + zahl;
            }
            Console.WriteLine($"Das Ergebnis ist {ergebnis}");
      
        }
    
        }

    }
