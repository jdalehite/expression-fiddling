using ExpressionFiddling;
using Newtonsoft.Json;
var settings = new JsonSerializerSettings() { TypeNameHandling = TypeNameHandling.Objects };
var file = File.ReadAllText("conversations.json");
var config = JsonConvert.DeserializeObject<ConversationConfig>(file, settings);
if(config == null)
{
    Console.WriteLine("missing conversation file");
    return;
}
var handler = new ConversationHandler(config);
handler.Start();

Console.ReadKey();
Console.WriteLine("done");