using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MSTeamsHistory.Models.Graph.Members
{
    public class Member
    {
        [JsonProperty("@odata.type")] public string OdataType { get; set; }

        [JsonProperty("id")] public string Id { get; set; }

        [JsonProperty("roles")] public List<object> Roles { get; set; }

        [JsonProperty("displayName")] public string DisplayName { get; set; }

        [JsonProperty("userId")] public Guid UserId { get; set; }

        [JsonProperty("email")] public object Email { get; set; }
    }
}