using System.Text.Json.Serialization;

namespace Auxlabs.SimpleTelegram.Rest.Requests
{
    public class GetUpdatesParams
    {
        /// <summary>
        /// Identifier of the first update to be returned.
        /// </summary>
        [JsonPropertyName("offset"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Offset { get; set; }

        /// <summary>
        /// Limits the number of updates to be retrieved.
        /// </summary>
        [JsonPropertyName("limit"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Limit { get; set; }

        /// <summary>
        /// Timeout in seconds for long polling.
        /// </summary>
        [JsonPropertyName("timeout"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? Timeout { get; set; }

        /// <summary>
        /// A list of the update types you want your bot to receive.
        /// </summary>
        [JsonPropertyName("allowed_updates"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string[]? AllowedUpdates { get; set; }
    }
}
