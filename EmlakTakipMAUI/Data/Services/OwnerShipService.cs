using EmlakTakipMAUI.Model;
using System.Text;
using System.Text.Json;


namespace EmlakTakipMAUI.Data;

public class OwnerShipService : IOwnerShipService
{
    private readonly HttpClient _httpClient;

    public OwnerShipService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri(URLList.BaseUrll);
    }

    public async Task Add(OwnerShip ownerShip)
    {
        var json = JsonSerializer.Serialize(ownerShip);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(URLList.OwnerShipAdd, data);

        response.EnsureSuccessStatusCode();
    }

    public async Task Delete(OwnerShip ownerShip)
    {
        var json = JsonSerializer.Serialize(ownerShip);
        var data = new StringContent(json, Encoding.UTF8, "application/json");
        var response = await _httpClient.PostAsync(URLList.OwnerShipDelete, data);

        response.EnsureSuccessStatusCode();
    }

    public async Task<List<OwnerShip>> GetAll()
    {
        var response = await _httpClient.GetAsync(URLList.OwnerShipGetAll);

        response.EnsureSuccessStatusCode();

        using var responseContent = await response.Content.ReadAsStreamAsync();
        return await JsonSerializer.DeserializeAsync<List<OwnerShip>>(responseContent);
    }

    public async Task<OwnerShip> GetById(int id)
    {
        var response = await _httpClient.GetAsync($"{URLList.OwnerShipGetById}/{id}");

        response.EnsureSuccessStatusCode();

        using var responseContent = await response.Content.ReadAsStreamAsync();
        return await JsonSerializer.DeserializeAsync<OwnerShip>(responseContent);
    }

    public async Task Update(OwnerShip ownerShip)
    {
        var json = JsonSerializer.Serialize(ownerShip);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync($"{URLList.OwnerShipUpdate}/{ownerShip.id}", data);

        response.EnsureSuccessStatusCode();
    }
}

