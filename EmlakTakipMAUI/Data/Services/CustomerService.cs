using EmlakTakipMAUI.Model;
using Newtonsoft.Json;

namespace EmlakTakipMAUI.Data.IServices;

public class CustomerService : GenericService<Customer, List<Customer>>, ICustomerService
{
    public async Task Add(Customer customer)
    {
        var response = await SendRequest(URLList.CustomerAdd, HttpMethod.Post, customer);
    }

    public async Task Delete(Customer customer)
    {
        var response = await SendRequest(URLList.CustomerDelete + "/" + customer.Id, HttpMethod.Post, customer);
    }

    public async Task<List<Customer>> GetAll()
    {
        // Tüm kategorileri getiren bir endpoint ve HTTP metodu kullanarak işlemi gerçekleştir
        var response = await GetAllGeneric(URLList.CustomerGetAll);
        // Dönen yanıtı doğrudan List<Customer> olarak döndürüyoruz
        return JsonConvert.DeserializeObject<List<Customer>>(response.ToString());
    }

    public async Task<Customer> GetById(int id)
    {
        var response = await SendRequest(URLList.CustomerGetById + "/" + id, HttpMethod.Get, default(Customer));
        return JsonConvert.DeserializeObject<Customer>(response.ToString());
    }


    public async Task Update(Customer customer)
    {
        var response = await SendRequest(URLList.CustomerUpdate, HttpMethod.Post, customer);
    }
}
