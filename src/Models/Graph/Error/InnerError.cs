using System;
using Newtonsoft.Json;

namespace MSTeamsHistory.Models.Graph.Error
{
    public class InnerError
    {
        [JsonProperty("request-id")] public Guid RequestId { get; set; }

        [JsonProperty("date")] public DateTimeOffset Date { get; set; }

        [JsonProperty("status")] public long Status { get; set; }

        [JsonProperty("code")] public long Code { get; set; }

        [JsonProperty("message")] public string Message { get; set; }
    }
}