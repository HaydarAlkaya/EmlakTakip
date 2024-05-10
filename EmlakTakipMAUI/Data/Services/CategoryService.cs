using EmlakTakipMAUI.Model;
using Newtonsoft.Json;

namespace EmlakTakipMAUI.Data;

public class CategoryService : GenericService<Category, List<Category>>, ICategoryService
{
    public async Task Add(Category category)
    {
        var response = await SendRequest(URLList.CategoryAdd, HttpMethod.Post, category);
    }

    public async Task Delete(Category category)
    {
        var response = await SendRequest(URLList.CategoryDelete+"/"+category.Id, HttpMethod.Post, category);
    }

    public async Task<List<Category>> GetAll()
    {
        // Tüm kategorileri getiren bir endpoint ve HTTP metodu kullanarak işlemi gerçekleştir
        var response = await GetAllGeneric(URLList.CategoryGetAll);
        // Dönen yanıtı doğrudan List<Category> olarak döndürüyoruz
        return JsonConvert.DeserializeObject<List<Category>>(response.ToString());
    }

    public async Task<Category> GetById(int id)
    {
        var response = await SendRequest(URLList.CategoryGetById + "/" + id, HttpMethod.Get, default(Category));
        return JsonConvert.DeserializeObject<Category>(response.ToString());
    }


    public async Task Update(Category category)
    {
        var response = await SendRequest(URLList.CategoryUpdate, HttpMethod.Post, category);
    }
}

