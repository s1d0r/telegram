using System.Text.Json.Serialization;

namespace s1d0r.telegram
{
    public class Result
    {
        [JsonPropertyName("update_id")]
        public int UpdateId { get; set; }

        [JsonPropertyName("message")]
        public Message Message { get; set; }
    }
}