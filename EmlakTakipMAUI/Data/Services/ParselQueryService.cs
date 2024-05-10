using EmlakTakipMAUI.Model;
using Newtonsoft.Json;

namespace EmlakTakipMAUI.Data;

public class ParselQueryService : GenericService<ParselQuery, List<ParselQuery>>, IParselQueryService
{
    public async Task Add(ParselQuery parselQuery)
    {
        var response = await SendRequest(URLList.ParselQueryAdd, HttpMethod.Post, parselQuery);
    }

    public async Task Delete(ParselQuery parselQuery)
    {
        var response = await SendRequest(URLList.ParselQueryDelete + "/" + parselQuery.Id, HttpMethod.Post, parselQuery);
    }

    public async Task<List<ParselQuery>> GetAll()
    {
        // Tüm kategorileri getiren bir endpoint ve HTTP metodu kullanarak işlemi gerçekleştir
        var response = await GetAllGeneric(URLList.ParselQueryGetAll);
        // Dönen yanıtı doğrudan List<ParselQuery> olarak döndürüyoruz
        return JsonConvert.DeserializeObject<List<ParselQuery>>(response.ToString());
    }

    public async Task<ParselQuery> GetById(int id)
    {
        var response = await SendRequest(URLList.ParselQueryGetById + "/" + id, HttpMethod.Get, default(ParselQuery));
        return JsonConvert.DeserializeObject<ParselQuery>(response.ToString());
    }


    public async Task Update(ParselQuery parselQuery)
    {
        var response = await SendRequest(URLList.ParselQueryUpdate, HttpMethod.Post, parselQuery);
    }
}
