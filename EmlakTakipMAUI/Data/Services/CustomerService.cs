using EmlakTakipMAUI.Model;
using System.Text;
using System.Text.Json;

namespace EmlakTakipMAUI.Data.IServices;

public class CustomerService : ICustomerService
{
    private readonly HttpClient _httpClient;

    public CustomerService(HttpClient httpClient)
    {
        _httpClient = httpClient;
        _httpClient.BaseAddress = new Uri(URLList.BaseUrll);
    }

    public async Task Add(Customer customer)
    {
        var json = JsonSerializer.Serialize(customer);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PostAsync(URLList.CustomerAdd, data);

        response.EnsureSuccessStatusCode();
    }

    public async Task Delete(Customer customer)
    {
        var response = await _httpClient.DeleteAsync($"{URLList.CustomerDelete}/{customer.id}");

        response.EnsureSuccessStatusCode();
    }

    public async Task<List<Customer>> GetAll()
    {
        var response = await _httpClient.GetAsync(URLList.CustomerGetAll);

        response.EnsureSuccessStatusCode();

        using var responseContent = await response.Content.ReadAsStreamAsync();
        return await JsonSerializer.DeserializeAsync<List<Customer>>(responseContent);
    }

    public async Task<Customer> GetById(int id)
    {
        var response = await _httpClient.GetAsync($"{URLList.CustomerGetById}/{id}");

        response.EnsureSuccessStatusCode();

        using var responseContent = await response.Content.ReadAsStreamAsync();
        return await JsonSerializer.DeserializeAsync<Customer>(responseContent);
    }

    public async Task Update(Customer customer)
    {
        var json = JsonSerializer.Serialize(customer);
        var data = new StringContent(json, Encoding.UTF8, "application/json");

        var response = await _httpClient.PutAsync($"{URLList.CustomerUpdate}/{customer.id}", data);

        response.EnsureSuccessStatusCode();
    }
}
