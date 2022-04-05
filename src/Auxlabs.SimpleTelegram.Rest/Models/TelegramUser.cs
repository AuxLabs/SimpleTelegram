using System.Text.Json.Serialization;

namespace Auxlabs.SimpleTelegram.Rest.Models
{
    public class TelegramUser
    {
        public TelegramUser(ulong id, bool isBot, string firstName)
            => (Id, IsBot, FirstName) = (id, isBot, firstName);

        /// <summary>
        /// Unique identifier for this user or bot.
        /// </summary>
        [JsonPropertyName("id")]
        public ulong Id { get; init; }

        /// <summary>
        /// True, if this user is a bot.
        /// </summary>
        [JsonPropertyName("is_bot")]
        public bool IsBot { get; init; }

        /// <summary>
        /// User's or bot's first name
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName { get; init; }

        /// <summary>
        /// User's or bot's last name
        /// </summary>
        [JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        /// <summary>
        /// User's or bot's username
        /// </summary>
        [JsonPropertyName("username")]
        public string? Username { get; set; }

        /// <summary>
        /// IETF language tag of the user's language
        /// </summary>
        [JsonPropertyName("language_code")]
        public string? LanguageCode { get; set; }

        /// <summary>
        /// True, if the bot can be invited to groups.
        /// </summary>
        [JsonPropertyName("can_join_groups")]
        public bool? CanJoinGroups { get; set; }

        /// <summary>
        /// True, if privacy mode is disabled for the bot.
        /// </summary>
        [JsonPropertyName("can_read_all_group_messages")]
        public bool? CanReadAllGroupMessages { get; set; }

        /// <summary>
        /// True, if the bot supports inline queries.
        /// </summary>
        [JsonPropertyName("supports_inline_queries")]
        public bool? SupportsInlineQueries { get; set; }
    }
}
