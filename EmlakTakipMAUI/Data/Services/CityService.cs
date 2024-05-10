using EmlakTakipMAUI.Model;
using Newtonsoft.Json;

namespace EmlakTakipMAUI.Data;

public class CityService :GenericService<City,List<City>>, ICityService
{
    public async Task Add(City t)
    {
        var response = await SendRequest(URLList.CityAdd, HttpMethod.Post, t);
    }

    public async Task Delete(City t)
    {
        var response = await SendRequest(URLList.CityDelete, HttpMethod.Post, t);
    }

    public async Task<List<City>> GetAll()
    {
        // Tüm kategorileri getiren bir endpoint ve HTTP metodu kullanarak işlemi gerçekleştir
        var response = await GetAllGeneric(URLList.CityGetAll);
        // Dönen yanıtı doğrudan List<Category> olarak döndürüyoruz
        return JsonConvert.DeserializeObject<List<City>>(response.ToString());
    }

    public async Task<City> GetById(int id)
    {
        var response = await SendRequest(URLList.CityGetById + "/" + id, HttpMethod.Get, default(City));
        return JsonConvert.DeserializeObject<City>(response.ToString());
    }

    public async Task Update(City t)
    {
        var response = await SendRequest(URLList.CityUpdate, HttpMethod.Post, t);
    }
}
