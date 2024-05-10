using EmlakTakipMAUI.Model;
using Newtonsoft.Json;

namespace EmlakTakipMAUI.Data;

public class OwnerShipService : GenericService<OwnerShip, List<OwnerShip>>, IOwnerShipService
{
    public async Task Add(OwnerShip ownerShip)
    {
        var response = await SendRequest(URLList.OwnerShipAdd, HttpMethod.Post, ownerShip);
    }

    public async Task Delete(OwnerShip ownerShip)
    {
        var response = await SendRequest(URLList.OwnerShipDelete + "/" + ownerShip.Id, HttpMethod.Post, ownerShip);
    }

    public async Task<List<OwnerShip>> GetAll()
    {
        // Tüm kategorileri getiren bir endpoint ve HTTP metodu kullanarak işlemi gerçekleştir
        var response = await GetAllGeneric(URLList.OwnerShipGetAll);
        // Dönen yanıtı doğrudan List<OwnerShip> olarak döndürüyoruz
        return JsonConvert.DeserializeObject<List<OwnerShip>>(response.ToString());
    }

    public async Task<OwnerShip> GetById(int id)
    {
        var response = await SendRequest(URLList.OwnerShipGetById + "/" + id, HttpMethod.Get, default(OwnerShip));
        return JsonConvert.DeserializeObject<OwnerShip>(response.ToString());
    }


    public async Task Update(OwnerShip ownerShip)
    {
        var response = await SendRequest(URLList.OwnerShipUpdate, HttpMethod.Post, ownerShip);
    }
}