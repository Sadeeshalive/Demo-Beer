using Beer.Core.Entities.Beer;
using Beer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.IO;
using System.Text.Json;
using System.Web.Http;

namespace Beer.Infrastructure.Repositories
{
    public class BeerRepository :IBeerRepository
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger _logger;
        public BeerRepository(IHttpClientFactory httpClientFactory, ILogger<IBeerRepository> logger)
        {
            _httpClient = httpClientFactory.CreateClient();
            _logger = logger;
        }
        public async Task<IEnumerable<Core.Entities.Beer.Beer>> GetBeerById(string id)
        {
            var uri = new UriBuilder($"https://api.punkapi.com/v2/beers?page=1&per_page=10");
            var request = new HttpRequestMessage(HttpMethod.Get, uri.Uri);
            return await Get<IEnumerable<Core.Entities.Beer.Beer>>(request);
        }
        private async Task<T> Get<T>(HttpRequestMessage request)
        {
            if (_httpClient != null)
            {
                try
                {
                    var response = await _httpClient.GetAsync(request.RequestUri);

                    if (!response.IsSuccessStatusCode)
                    {
                        throw new HttpResponseException(response);
                    }
                    if (response.IsSuccessStatusCode)
                    {
                        var resultJson = await response.Content.ReadAsStringAsync();

                        if (!string.IsNullOrWhiteSpace(resultJson))
                        {

                            var result = JsonSerializer.Deserialize<T>(resultJson);

                            return (T)result;
                        }
                    }
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, $"Api Called Failed: {ex.Message}");
                }
            }
            return default(T);
        }
    }
}
