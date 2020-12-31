using System;
using Newtonsoft.Json.Linq;

namespace dotnethelloworld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            JObject message = new JObject();
            message.Add("name", new JValue("visual studio"));
            JObject result = new Hello.MainClass().xMain(message);
            Console.WriteLine(result);
        }
    }
}