using System.Globalization;
using System.Runtime.CompilerServices;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] emails = new string []
        {
            "linh.le@tecalliance.net",
            "abc@tecalliance.net",
            "qwertz@tecalliance.net"
        };
        foreach(string email in emails)
        {
            Console.WriteLine($"Die Email lautet: {email}");
        }
        for(int position=0; position < emails.Length; position++)
        {
            Console.WriteLine($"Die Email lautet:{emails[position]}");
        }
        }
        }
    }