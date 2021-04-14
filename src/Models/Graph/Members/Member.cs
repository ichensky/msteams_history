using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace MSTeamsHistory.Models.Graph.Members
{
    public class  Member
    {
        [JsonProperty("@odata.type")]
        public string OdataType { get; set; }

        [JsonProperty("id")]
        public String Id { get; set; }

        [JsonProperty("roles")]
        public List<object> Roles { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("userId")]
        public Guid UserId { get; set; }

        [JsonProperty("email")]
        public object Email { get; set; }
    }
}