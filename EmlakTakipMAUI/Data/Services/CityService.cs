using EmlakTakipMAUI.Model;
using System.Text;
using System.Text.Json;

namespace EmlakTakipMAUI.Data;

public class CityService : ICityService
{
    private readonly HttpClient _httpClient;

    public CityService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri(URLList.BaseUrll);
    }

    public async Task Add(City city)
    {
        var json = JsonSerializer.Serialize(city);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(URLList.CityAdd, data);

        response.EnsureSuccessStatusCode();
    }

    public async Task Delete(City city)
    {
        var json = JsonSerializer.Serialize(city);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(URLList.CityDelete, data);

        response.EnsureSuccessStatusCode();
    }

    public async Task<List<City>> GetAll()
    {
        var response = await _httpClient.GetAsync(URLList.CityGetAll);

        response.EnsureSuccessStatusCode();

        using var responseContent = await response.Content.ReadAsStreamAsync();
        return await JsonSerializer.DeserializeAsync<List<City>>(responseContent);

    }

    public async Task<City> GetById(int id)
    {
        var response = await _httpClient.GetAsync($"{URLList.CityGetById}/{id}");

        response.EnsureSuccessStatusCode();

        using var responseContent = await response.Content.ReadAsStreamAsync();
        return await JsonSerializer.DeserializeAsync<City>(responseContent);
    }

    public async Task Update(City city)
    {
        var json = JsonSerializer.Serialize(city);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PutAsync($"{URLList.CityUpdate}/{city.id}", data);

        response.EnsureSuccessStatusCode();
    }
}
