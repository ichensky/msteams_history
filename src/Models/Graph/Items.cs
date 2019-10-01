using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSTeamsHistory.Models.Graph
{
    public partial class Items<T>
    {
        [JsonProperty("@odata.context")]
        public Uri OdataContext { get; set; }

        [JsonProperty("@odata.count")]
        public long OdataCount { get; set; }

        [JsonProperty("@odata.nextLink")]
        public Uri OdataNextLink { get; set; }

        [JsonProperty("value")]
        public List<T> Value { get; set; }
        [JsonProperty("error")]
        public Error.Error Error { get; set; }
    }
}
