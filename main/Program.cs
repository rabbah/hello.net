using System;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace dotnethelloworld
{
    class MainClass
    {
        public static async Task Main(string[] args)
        {
            JObject message = new JObject();
            message.Add("name", new JValue("visual studio"));
            Task<JObject> task = new Hello.MainClass().MainAsync(message);
            JObject result = await task;
            Console.WriteLine(result);
        }
    }
}