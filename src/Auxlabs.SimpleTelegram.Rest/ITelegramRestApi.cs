using Auxlabs.SimpleTelegram.Rest.Models;
using Auxlabs.SimpleTelegram.Rest.Requests;
using RestEase;

namespace Auxlabs.SimpleTelegram.Rest
{
    [BaseAddress("{apiUrl}bot{apiToken}/")]
    [Header("User-Agent", "Auxlabs (https://github.com/AuxLabs/SimpleTelegram)")]
    internal interface ITelegramRestApi : IDisposable
    {
        [Path("apiUrl")]
        string ApiUrl { get; set; }
        [Path("apiToken")]
        string ApiToken { get; set; }

        // Updates Methods

        [Get("getUpdates")]
        Task<IEnumerable<object>> GetUpdatesAsync([Body]GetUpdatesParams args);

        // General Methods

        [Get("getMe")]
        Task<TelegramUser> GetMeAsync();
    }
}
