using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace KanyeAndRonConversation
{
    public class QuoteGenerator
    {
        //Method 1 (Kanye Quotes)

        public static void KanyeQuote()
        {

            var kanyeURL = "https://api.kanye.rest";

            var client = new HttpClient();

            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;

            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();


            Console.WriteLine($"");
            Console.WriteLine($"Kanye: '{kanyeQuote}'");
            Console.WriteLine($"");

        }


        //Method 2 (Ron Quotes)

        public static void RonQuote()
        {
            var client = new HttpClient();

            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            var ronResponse = client.GetStringAsync(ronURL).Result;

            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('{', ' ').Replace('}', ' ').Trim();



            Console.WriteLine($"");
            Console.WriteLine($"Ron: '{ronQuote}'");
            Console.WriteLine($"");


        }


    }
}
