using IDHLDeveloperTest.Models;
using System.Text.Json;

namespace IDHLDeveloperTest.Services
{
    public class ClientService : IClientService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ClientService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<CharacterList> GetCharacters(int pageNumber, string? searchParam)
        {
            var path = $"character?page={pageNumber}&pageSize=6{(!string.IsNullOrEmpty(searchParam) ? $"&name={searchParam}" : string.Empty)}";
            return await GetDisneyResource<CharacterList>(path);
        }

        public async Task<Character> GetCharacter(int id)
        {
            var response = await GetDisneyResource<SingleCharacter>($"character/{id}");
            return response.Data;
        }

        private async Task<T> GetDisneyResource<T>(string path)
        {
            var client = _httpClientFactory.CreateClient();
            var stream = await client.GetStreamAsync($"https://api.disneyapi.dev/{path}");
            return await JsonSerializer.DeserializeAsync<T>(stream, new JsonSerializerOptions{PropertyNameCaseInsensitive = true});
        }
    }
}
