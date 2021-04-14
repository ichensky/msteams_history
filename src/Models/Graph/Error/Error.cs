using Newtonsoft.Json;

namespace MSTeamsHistory.Models.Graph.Error
{
    public class Error
    {
        [JsonProperty("code")] public string Code { get; set; }

        [JsonProperty("message")] public string Message { get; set; }

        [JsonProperty("innerError")] public InnerError InnerError { get; set; }
    }
}