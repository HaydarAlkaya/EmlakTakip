using EmlakTakipMAUI.Model;
using System.Text;
using System.Text.Json;

namespace EmlakTakipMAUI.Data;

public class NeighbourhoodService : INeighbourhoodService
{
    private readonly HttpClient _httpClient;

    public NeighbourhoodService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri(URLList.BaseUrll);
    }

    public async Task Add(Neighbourhood neighbourhood)
    {
        var json = JsonSerializer.Serialize(neighbourhood);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(URLList.NeighbourhoodAdd, data);

        response.EnsureSuccessStatusCode();
    }

    public async Task Delete(Neighbourhood neighbourhood)
    {
        var json = JsonSerializer.Serialize(neighbourhood);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(URLList.NeighbourhoodDelete, data);

        response.EnsureSuccessStatusCode();
    }

    public async Task<List<Neighbourhood>> GetAll()
    {
        var response = await _httpClient.GetAsync(URLList.NeighbourhoodGetAll);

        response.EnsureSuccessStatusCode();

        using var responseContent = await response.Content.ReadAsStreamAsync();
        return await JsonSerializer.DeserializeAsync<List<Neighbourhood>>(responseContent);
    }

    public async Task<Neighbourhood> GetById(int id)
    {
        var response = await _httpClient.GetAsync($"{URLList.NeighbourhoodGetById}/{id}");

        response.EnsureSuccessStatusCode();

        using var responseContent = await response.Content.ReadAsStreamAsync();
        return await JsonSerializer.DeserializeAsync<Neighbourhood>(responseContent);
    }

    public async Task Update(Neighbourhood neighbourhood)
    {
        var json = JsonSerializer.Serialize(neighbourhood);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PutAsync($"{URLList.NeighbourhoodUpdate}/{neighbourhood.id}", data);

        response.EnsureSuccessStatusCode();
    }
}
