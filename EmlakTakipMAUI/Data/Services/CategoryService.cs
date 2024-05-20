using EmlakTakipMAUI.Model;
using System.Text;
using System.Text.Json;

namespace EmlakTakipMAUI.Data;

public class CategoryService : ICategoryService
{
    private readonly HttpClient _httpClient;

    public CategoryService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri(URLList.BaseUrll);
    }

    public async Task Add(Category category)
    {
        var json = JsonSerializer.Serialize(category);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(URLList.CategoryAdd, data);

        response.EnsureSuccessStatusCode();
    }

    public async Task Delete(Category category)
    {
        var json = JsonSerializer.Serialize(category);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(URLList.CategoryDelete, data);

        response.EnsureSuccessStatusCode();
    }

    public async Task<List<Category>> GetAll()
    {
        var response = await _httpClient.GetAsync(URLList.CategoryGetAll);

        response.EnsureSuccessStatusCode();

        using var responseContent = await response.Content.ReadAsStreamAsync();
        return await JsonSerializer.DeserializeAsync<List<Category>>(responseContent);
    }

    public async Task<Category> GetById(int id)
    {
        var response = await _httpClient.GetAsync($"{URLList.CategoryGetById}/{id}");

        response.EnsureSuccessStatusCode();

        using var responseContent = await response.Content.ReadAsStreamAsync();
        return await JsonSerializer.DeserializeAsync<Category>(responseContent);
    }

    public async Task Update(Category category)
    {
        var json = JsonSerializer.Serialize(category);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PutAsync($"{URLList.CategoryUpdate}/{category.id}", data);

        response.EnsureSuccessStatusCode();
    }
}

