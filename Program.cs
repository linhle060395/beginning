using System.Globalization;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo cu = new CultureInfo("en-us");
            CultureInfo.CurrentCulture = cu;

            string text = "Das ist ein Text";
            Console.WriteLine(text);

            int zahl = 21;
            Console.WriteLine(zahl);

            double kommazahl = 21.3;
            Console.WriteLine(kommazahl);

            float weiterFliesKommazahl = 26.33456516623f;
            Console.WriteLine(weiterFliesKommazahl);

            decimal flieskomma = 26.5M;
            Console.WriteLine(flieskomma);

            bool wahrheitswert = true;
            Console.WriteLine(wahrheitswert);
            bool anders = false;
            Console.WriteLine(anders);

            char buchstabe = 'A';
            char buschstabe = (char)48;
            Console.WriteLine(buchstabe);

            long langezahl = 123456789123456789;
            Console.WriteLine(langezahl);

            uint positiveZahlen = 123;
            Console.WriteLine(positiveZahlen);


            string [] myArray = new string [10];
            myArray[0] = "ersten Wert";
            myArray [9] = "letzter Wert";
            Console.WriteLine(myArray);

            List<string> myList = new List<string>();
            

            myList.Add("Linh");
            myList.Add("Weikersheim");
            myList.Add("Ismaning");

            Console.WriteLine(myList[0]);
            Console.WriteLine(myList[1]);
            Console.WriteLine(myList[2]);
        }

    }
}