using System.Text.Json.Serialization;

namespace s1d0r.telegram
{
    public class Message
    {
        [JsonPropertyName("message_id")]
        public int MessageId { get; set; }

        [JsonPropertyName("from")]
        public From From { get; set; }

        [JsonPropertyName("chat")]
        public Chat Chat { get; set; }

        [JsonPropertyName("date")]
        public int Date { get; set; }
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}