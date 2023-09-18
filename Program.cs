using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Xml.XPath;
using Microsoft.VisualBasic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           string text = "MissiSsiPpi";

           int letterM = text.Count(c => c == 'M' || c == 'm');
           int letterI = text.Count(c => c == 'I' || c == 'i');
           int letterS = text.Count(c => c == 'S' || c == 's');
           int letterP = text.Count(c => c == 'P' || c == 'p');
           
            {
            Console.Write($"There are {letterM} M, {letterI} I, {letterS} S, {letterP} P  in the text");
            }
        }
    }
}
