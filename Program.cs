﻿using System.Globalization;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1 = 600;
            int zahl2 = 200;

            int ergebnis1 = zahl1 + zahl2;
            Console.WriteLine(ergebnis1);

            int ergebnis2 = zahl1 - zahl2;
            Console.WriteLine(ergebnis2);

            int ergebnis3 = zahl1 * zahl2;
            Console.WriteLine(ergebnis3);

            int ergebnis4 = zahl1 / zahl2;
            Console.WriteLine(ergebnis4);

            int ergebnis5 = zahl1 % zahl2;
            Console.WriteLine(ergebnis5);

            zahl1++;
            Console.WriteLine(zahl1);

            zahl2--;
            Console.WriteLine(zahl2);

            zahl1 *= 2; //zahl1 = zahl1 * 2;
            Console.WriteLine(zahl1);

            zahl2 += 25; //zahl2 = zahl2 + 25;
            Console.WriteLine(zahl2);
        }

    }
}