using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeAndRonConversation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hey Kanye and Ron!");
            Console.WriteLine($"Tell me some of your thoughts?");


            for (int i = 0; i < 1; i++)
            {
                QuoteGenerator.KanyeQuote();

                QuoteGenerator.RonQuote();
            }
            
        }
    }
}
