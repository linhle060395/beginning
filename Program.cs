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
            Console.WriteLine("Gebe mir einen Zahl");
            int Zahl = Convert.ToInt32(Console.ReadLine());

            for(int i = 3; i < Zahl; i++)
            {
                Console.WriteLine($"The numbers are {i}");
            }

            
            
        }
    }
}
