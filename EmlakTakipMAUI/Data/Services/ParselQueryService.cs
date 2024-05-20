using EmlakTakipMAUI.Model;
using System.Text;
using System.Text.Json;

namespace EmlakTakipMAUI.Data;

public class ParselQueryService : IParselQueryService
{
    private readonly HttpClient _httpClient;

    public ParselQueryService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri(URLList.BaseUrll);
    }

    public async Task Add(ParselQuery parselQuery)
    {
        var json = JsonSerializer.Serialize(parselQuery);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(URLList.ParselQueryAdd, data);

        response.EnsureSuccessStatusCode();
    }

    public async Task Delete(ParselQuery parselQuery)
    {
        var json = JsonSerializer.Serialize(parselQuery);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(URLList.ParselQueryDelete, data);

        response.EnsureSuccessStatusCode();
    }

    public async Task<List<ParselQuery>> GetAll()
    {
        var response = await _httpClient.GetAsync(URLList.ParselQueryGetAll);

        response.EnsureSuccessStatusCode();

        using var responseContent = await response.Content.ReadAsStreamAsync();
        return await JsonSerializer.DeserializeAsync<List<ParselQuery>>(responseContent);
    }

    public async Task<ParselQuery> GetById(int id)
    {
        var response = await _httpClient.GetAsync($"{URLList.ParselQueryGetById}/{id}");

        response.EnsureSuccessStatusCode();

        using var responseContent = await response.Content.ReadAsStreamAsync();
        return await JsonSerializer.DeserializeAsync<ParselQuery>(responseContent);
    }

    public async Task Update(ParselQuery parselQuery)
    {
        var json = JsonSerializer.Serialize(parselQuery);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PutAsync($"{URLList.ParselQueryUpdate}/{parselQuery.id}", data);

        response.EnsureSuccessStatusCode();
    }
}
