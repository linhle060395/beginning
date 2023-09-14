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
               
               Console.WriteLine("Give me your name");
               string name = Console.ReadLine();

                for(int i = 0; i<10; i++);
                {
                    if(name.Contains("e"))
                    {
                       Console.WriteLine(name);
                    }
                    else
                    {
                        Console.WriteLine(" ");
                    }
                }
                 }

            }
    }