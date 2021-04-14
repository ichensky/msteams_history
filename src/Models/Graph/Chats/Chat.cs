using System;
using Newtonsoft.Json;

namespace MSTeamsHistory.Models.Graph.Chats
{
    public class Chat
    {
        [JsonProperty("id")] public string Id { get; set; }

        [JsonProperty("topic")] public object Topic { get; set; }

        [JsonProperty("createdDateTime")] public DateTimeOffset CreatedDateTime { get; set; }

        [JsonProperty("lastUpdatedDateTime")] public DateTimeOffset LastUpdatedDateTime { get; set; }
    }
}