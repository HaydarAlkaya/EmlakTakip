using EmlakTakipMAUI.Model;
using Newtonsoft.Json;

namespace EmlakTakipMAUI.Data;

public class NeighbourhoodService : GenericService<Neighbourhood, List<Neighbourhood>>, INeighbourhoodService
{
    public async Task Add(Neighbourhood neighbourhood)
    {
        var response = await SendRequest(URLList.NeighbourhoodAdd, HttpMethod.Post, neighbourhood);
    }

    public async Task Delete(Neighbourhood neighbourhood)
    {
        var response = await SendRequest(URLList.NeighbourhoodDelete + "/" + neighbourhood.Id, HttpMethod.Post, neighbourhood);
    }

    public async Task<List<Neighbourhood>> GetAll()
    {
        // Tüm kategorileri getiren bir endpoint ve HTTP metodu kullanarak işlemi gerçekleştir
        var response = await GetAllGeneric(URLList.NeighbourhoodGetAll);
        // Dönen yanıtı doğrudan List<Neighbourhood> olarak döndürüyoruz
        return JsonConvert.DeserializeObject<List<Neighbourhood>>(response.ToString());
    }

    public async Task<Neighbourhood> GetById(int id)
    {
        var response = await SendRequest(URLList.NeighbourhoodGetById + "/" + id, HttpMethod.Get, default(Neighbourhood));
        return JsonConvert.DeserializeObject<Neighbourhood>(response.ToString());
    }


    public async Task Update(Neighbourhood neighbourhood)
    {
        var response = await SendRequest(URLList.NeighbourhoodUpdate, HttpMethod.Post, neighbourhood);
    }
}
