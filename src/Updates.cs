using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace s1d0r.telegram
{
    public class Updates
    {
        [JsonPropertyName("ok")]
        public bool Ok { get; set; }

        [JsonPropertyName("result")]
        public List<Result> Results { get; set; }
    }
}