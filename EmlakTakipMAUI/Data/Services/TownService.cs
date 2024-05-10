using EmlakTakipMAUI.Model;
using Newtonsoft.Json;

namespace EmlakTakipMAUI.Data;

public class TownService : GenericService<Town, List<Town>>, ITownService
{
    public async Task Add(Town town)
    {
        var response = await SendRequest(URLList.TownAdd, HttpMethod.Post, town);
    }

    public async Task Delete(Town town)
    {
        var response = await SendRequest(URLList.TownDelete + "/" + town.Id, HttpMethod.Post, town);
    }

    public async Task<List<Town>> GetAll()
    {
        // Tüm kategorileri getiren bir endpoint ve HTTP metodu kullanarak işlemi gerçekleştir
        var response = await GetAllGeneric(URLList.TownGetAll);
        // Dönen yanıtı doğrudan List<Town> olarak döndürüyoruz
        return JsonConvert.DeserializeObject<List<Town>>(response.ToString());
    }

    public async Task<Town> GetById(int id)
    {
        var response = await SendRequest(URLList.TownGetById + "/" + id, HttpMethod.Get, default(Town));
        return JsonConvert.DeserializeObject<Town>(response.ToString());
    }


    public async Task Update(Town town)
    {
        var response = await SendRequest(URLList.TownUpdate, HttpMethod.Post, town);
    }
}