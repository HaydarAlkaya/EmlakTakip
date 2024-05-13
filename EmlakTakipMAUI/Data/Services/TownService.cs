using EmlakTakipMAUI.Model;
using System.Text;
using System.Text.Json;

namespace EmlakTakipMAUI.Data;

public class TownService : ITownService
{
    private readonly HttpClient _httpClient;

    public TownService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri(URLList.BaseUrll);
    }

    public async Task Add(Town town)
    {
        var json = JsonSerializer.Serialize(town);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(URLList.TownAdd, data);

        response.EnsureSuccessStatusCode();
    }

    public async Task Delete(Town town)
    {
        var response = await _httpClient.DeleteAsync($"{URLList.TownDelete}/{town.id}");

        response.EnsureSuccessStatusCode();
    }

    public async Task<List<Town>> GetAll()
    {
        var response = await _httpClient.GetAsync(URLList.TownGetAll);

        response.EnsureSuccessStatusCode();

        using var responseContent = await response.Content.ReadAsStreamAsync();
        return await JsonSerializer.DeserializeAsync<List<Town>>(responseContent);
    }

    public async Task<Town> GetById(int id)
    {
        var response = await _httpClient.GetAsync($"{URLList.TownGetById}/{id}");

        response.EnsureSuccessStatusCode();

        using var responseContent = await response.Content.ReadAsStreamAsync();
        return await JsonSerializer.DeserializeAsync<Town>(responseContent);
    }

    public async Task Update(Town town)
    {
        var json = JsonSerializer.Serialize(town);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PutAsync($"{URLList.TownUpdate}/{town.id}", data);

        response.EnsureSuccessStatusCode();
    }
}
