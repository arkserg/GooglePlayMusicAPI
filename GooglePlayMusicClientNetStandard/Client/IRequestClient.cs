using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;

namespace GooglePlayMusicClientNetStandard
{
    public interface IRequestClient
    {
        bool IsLoggedIn();
        Task<bool> LoginAsync(string email, string password);
        Task<List<T>> PerformIncrementalPostAsync<T>(string url, int itemsToGet = 0);
        Task<T> PerformPostAsync<T>(string url, JObject data);
        Task<T> PerformGetAsync<T>(string url, NameValueCollection additionalHeaders = null);
        Task<string> PerformGetStringAsync(string url, NameValueCollection additionalHeaders = null);
    }
}
