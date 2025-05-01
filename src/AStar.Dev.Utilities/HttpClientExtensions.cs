using System.Net.Http.Headers;

namespace AStar.Dev.Utilities;

/// <summary>
///
/// </summary>
public static class HttpClientExtensions
{
    /// <summary>
    ///
    /// </summary>
    /// <param name="httpClient"></param>
    /// <param name="bearerToken"></param>
    /// <returns></returns>
    public static HttpClient AddBearerToken(this HttpClient httpClient, string bearerToken)
    {
        _= httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", bearerToken);

        return httpClient;
    }
}