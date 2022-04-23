using System.Text.Json.Serialization;

namespace s1d0r.telegram
{
    public class From
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("is_bot")]
        public bool IsBot { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("username")]
        public string UserName { get; set; }

        [JsonPropertyName("language_code")]
        public string Language_code { get; set; }
    }
}