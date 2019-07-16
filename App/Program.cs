using Newtonsoft.Json;
using System;
using Utility;

namespace App
{

    class Greeting
    {
        public string Message { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var greeting = new Greeting() { Message = "Hello world!" };

            var jsonStr = JsonConvert.SerializeObject(greeting);

            Utils.Print(jsonStr);

            Helper.Print(jsonStr);
        }
    }
}