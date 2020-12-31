using Newtonsoft.Json.Linq;

namespace Hello
{
    public class MainClass
    {
        public JObject Main(JObject args)
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
    }
}