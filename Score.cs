using Newtonsoft.Json;

namespace hire_downs.command.Models;
public class ScoreItem {
    [JsonProperty(PropertyName = "username")]
    public string Username { get; set; }
    
    [JsonProperty(PropertyName = "score")]
    public string Score { get; set; }
}