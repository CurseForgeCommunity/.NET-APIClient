using CurseForge.APIClient.Exceptions;
using CurseForge.APIClient.Models;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CurseForge.APIClient
{
    public partial class ApiClient : IDisposable
    {
        private IServiceCollection _serviceCollection;
        private IServiceProvider _serviceProvider;
        private const string curseForgeApiBaseUrl = "https://api.curseforge.com";

        private readonly string _apiKey;
        private readonly long _partnerId;
        private readonly string _contactEmail;
        /// <summary>
        /// The delay between requests to the API, to help combat getting banned by the API.
        /// </summary>
        public TimeSpan RequestDelay { get; set; } = TimeSpan.Zero;

        public bool DebugOutput { get; set; } = false;

        public ApiClient(string apiKey, long partnerId, string contactEmail)
        {
            _apiKey = apiKey;
            _partnerId = partnerId;
            _contactEmail = contactEmail;

            InitHttpClientIfMissing();
        }

        public ApiClient(string apiKey, string contactEmail)
        {
            _apiKey = apiKey;
            _partnerId = -1;
            _contactEmail = contactEmail;

            InitHttpClientIfMissing();
        }

        public ApiClient(string apiKey)
        {
            _apiKey = apiKey;

            InitHttpClientIfMissing();
        }

        private void InitHttpClientIfMissing()
        {
            if (string.IsNullOrWhiteSpace(_apiKey))
            {
                throw new MissingApiKeyException("You need to provide an API key to be able to call the API");
            }

            BootstrapDependencyInjection();
        }

        private void BootstrapDependencyInjection()
        {
            if (_serviceCollection == null)
            {
                _serviceCollection = new ServiceCollection();
            }

            _serviceCollection.AddHttpClient("curseForgeClient", _httpClient =>
            {
                _httpClient.BaseAddress = new Uri(curseForgeApiBaseUrl);

                var cfUserAgent = new StringBuilder();

                cfUserAgent.Append("CurseForgeApiClient/" + Assembly.GetExecutingAssembly().GetName().Version);

                if (_partnerId > 0 || !string.IsNullOrWhiteSpace(_contactEmail))
                {
                    cfUserAgent.Append(" (");
                    if (_partnerId > 0)
                    {
                        cfUserAgent.Append(_partnerId);
                    }

                    if (!string.IsNullOrWhiteSpace(_contactEmail))
                    {
                        if (_partnerId > 0)
                        {
                            cfUserAgent.Append(";");
                        }

                        cfUserAgent.Append(_contactEmail);
                    }

                    cfUserAgent.Append(")");
                }

                _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", cfUserAgent.ToString());
                _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("x-api-key", _apiKey);
                _httpClient.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "application/json");
            });

            _serviceProvider = _serviceCollection.BuildServiceProvider();
        }

        internal string GetQuerystring(params (string Key, object Value)[] queryParameters)
        {
            return queryParameters.Count(k => k.Value != null) > 0 ? "?" +
                string.Join("&",
                    queryParameters
                        .Where(k => k.Value != null)
                        .Select(k => $"{System.Net.WebUtility.UrlEncode(k.Key)}={System.Net.WebUtility.UrlEncode(k.Value.ToString())}")) : string.Empty;
        }

        internal async Task<GenericListResponse<T>> GetList<T>(string endpoint, params (string Key, object Value)[] queryParameters)
        {
            var _httpClientFactory = _serviceProvider.GetService<IHttpClientFactory>();
            var _httpClient = _httpClientFactory.CreateClient("curseForgeClient");

            if(DebugOutput)
            {
                Console.WriteLine($"[GET] Calling {endpoint + GetQuerystring(queryParameters)}");
            }

            return await HandleListResponseMessage<T>(
                await _httpClient.GetAsync(
                    endpoint + GetQuerystring(queryParameters)
                )
            );
        }
        
        internal async Task<GenericResponse<T>> GetItem<T>(string endpoint, params (string Key, object Value)[] queryParameters)
        {
            var _httpClientFactory = _serviceProvider.GetService<IHttpClientFactory>();
            var _httpClient = _httpClientFactory.CreateClient("curseForgeClient");

            if (DebugOutput)
            {
                Console.WriteLine($"[GET] Calling {endpoint + GetQuerystring(queryParameters)}");
            }

            return await HandleResponseMessage<T>(
                await _httpClient.GetAsync(
                    endpoint + GetQuerystring(queryParameters)
                )
            );
        }

        internal async Task<GenericListResponse<T>> PostList<T>(string endpoint, object body)
        {
            var _httpClientFactory = _serviceProvider.GetService<IHttpClientFactory>();
            var _httpClient = _httpClientFactory.CreateClient("curseForgeClient");

            if (DebugOutput) {
                Console.WriteLine($"[POST] Calling {endpoint}");
                Console.WriteLine(JsonSerializer.Serialize(body));
            }

            return await HandleListResponseMessage<T>(
                await _httpClient.PostAsync(
                    endpoint,
                    new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json")
                )
            );
        }
        
        internal async Task<GenericResponse<T>> PostItem<T>(string endpoint, object body)
        {
            var _httpClientFactory = _serviceProvider.GetService<IHttpClientFactory>();
            var _httpClient = _httpClientFactory.CreateClient("curseForgeClient");

            if (DebugOutput)
            {
                Console.WriteLine($"[POST] Calling {endpoint}");
                Console.WriteLine(JsonSerializer.Serialize(body));
            }

            return await HandleResponseMessage<T>(
                await _httpClient.PostAsync(
                    endpoint,
                    new StringContent(JsonSerializer.Serialize(body), Encoding.UTF8, "application/json")
                )
            );
        }
        
        internal async Task<GenericListResponse<T>> HandleListResponseMessage<T>(HttpResponseMessage result)
        {
            if (RequestDelay > TimeSpan.Zero)
            {
                await Task.Delay(RequestDelay);
            }

            if(DebugOutput)
            {
                Console.WriteLine($"[RESPONSE] Code: {result.StatusCode}");
                Console.WriteLine(JsonSerializer.Serialize(result));
            }

            if (!result.IsSuccessStatusCode)
            {
                var errorMessage = await result.Content.ReadAsStringAsync();
                return new GenericListResponse<T>
                {
                    Error = new ErrorResponse
                    {
                        ErrorCode = (int)result.StatusCode,
                        ErrorMessage = errorMessage
                    }
                };
            }

            return JsonSerializer.Deserialize<GenericListResponse<T>>(await result.Content.ReadAsStringAsync());
        }

        internal async Task<GenericResponse<T>> HandleResponseMessage<T>(HttpResponseMessage result)
        {
            if (RequestDelay > TimeSpan.Zero)
            {
                await Task.Delay(RequestDelay);
            }

            if (DebugOutput)
            {
                Console.WriteLine($"[RESPONSE] Code: {result.StatusCode}");
                Console.WriteLine(JsonSerializer.Serialize(result));
            }

            if (!result.IsSuccessStatusCode)
            {
                var errorMessage = await result.Content.ReadAsStringAsync();

                if (string.IsNullOrWhiteSpace(errorMessage))
                {
                    var type = typeof(T).Name;
                    switch (result.StatusCode)
                    {
                        case HttpStatusCode.NotFound:
                        {
                            errorMessage = $"Could not find the {type}";
                            break;
                        }
                    }
                }
                
                return new GenericResponse<T>
                {
                    Error = new ErrorResponse
                    {
                        ErrorCode = (int)result.StatusCode,
                        ErrorMessage = errorMessage
                    }
                };
            }

            return JsonSerializer.Deserialize<GenericResponse<T>>(await result.Content.ReadAsStringAsync());
        }

        public void Dispose()
        {
            // Empty because of legacy
        }
    }
}
