using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gebe mir ein Zahl");
            int zahl = Convert.ToInt16(Console.ReadLine());

            for(int i=0; i<=zahl; i++)
            {
                if(i%2==0&&i!=0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}