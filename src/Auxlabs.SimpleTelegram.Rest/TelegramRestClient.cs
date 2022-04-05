using Auxlabs.SimpleTelegram.Rest.Models;
using Auxlabs.SimpleTelegram.Rest.Requests;
using RestEase;

namespace Auxlabs.SimpleTelegram.Rest
{
    public class TelegramRestClient : ITelegramRestApi, IDisposable
    {
        private readonly ITelegramRestApi _api;

        public string ApiUrl { get => _api.ApiUrl; set => _api.ApiUrl = value; }
        public string ApiToken { get => _api.ApiToken; set => _api.ApiToken = value; }

        // This is all messed up, fix it later or else >:(
        public TelegramRestClient()
            : this(TelegramConstants.BaseUrl) { }
        public TelegramRestClient(string baseUrl)
            : this(new HttpClient { BaseAddress = new Uri(baseUrl) }) { }
        public TelegramRestClient(HttpClient httpClient)
        {
            if (httpClient == null)
                throw new ArgumentNullException(nameof(httpClient));
            if (httpClient.BaseAddress == null)
                throw new InvalidOperationException(nameof(httpClient.BaseAddress));

            _api = RestClient.For<ITelegramRestApi>(httpClient);
        }
        public virtual void Dispose() => _api.Dispose();

        public Task<IEnumerable<object>> GetUpdatesAsync(GetUpdatesParams args)
            => _api.GetUpdatesAsync(args);

        public Task<TelegramUser> GetMeAsync()
            => _api.GetMeAsync();
    }
}
