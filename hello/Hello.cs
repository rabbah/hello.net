using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Hello
{
    public class MainClass
    {
        public JObject xMain(JObject args)
        {
            string name = "stranger";
            if (args.ContainsKey("name"))
            {
                name = args["name"].ToString();
            }
            JObject message = new JObject();
            message.Add("statusCode", new JValue(200));
            message.Add("body", new JValue($"Hello, {name}!"));
            return (message);
        }

        public async Task<JObject> MainAsync(JObject args)
        {
            await Task.Delay(10); // Just do a delay to have an async/await process occur.
            return xMain(args);
        }
    }
}