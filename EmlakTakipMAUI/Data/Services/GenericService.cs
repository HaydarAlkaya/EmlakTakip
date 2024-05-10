using Newtonsoft.Json;
using System.Text;

namespace EmlakTakipMAUI.Data;
public class GenericService<TRequest, TResponse>
{
    private string _baseUrl = URLList.BaseUrll;

    public async Task<TResponse> SendRequest(string endpoint, HttpMethod method, TRequest requestData)
    {
        var returnResponse = default(TResponse);
        try
        {
            using (var client = new HttpClient())
            {
                string url = $"{_baseUrl}{endpoint}";

                var serializeContent = JsonConvert.SerializeObject(requestData);

                var request = new HttpRequestMessage();
                request.Method = method;
                request.RequestUri = new Uri(url);
                request.Content = new StringContent(serializeContent, Encoding.UTF8, "application/json");

                var apiResponse = await client.SendAsync(request);

                if (apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var response = await apiResponse.Content.ReadAsStringAsync();
                    returnResponse = JsonConvert.DeserializeObject<TResponse>(response);
                }
            }
        }
        catch (Exception ex)
        {
            string msg = ex.Message;
        }
        return returnResponse;
    }

    // GetAll metodunun dönüş tipi List<TResponse> olarak değiştirildi
    public async Task<List<TResponse>> GetAllGeneric(string endpoint)
    {
        var response = await SendRequest(endpoint, HttpMethod.Get, default(TRequest));
        // Dönen yanıtı doğrudan List<TResponse> olarak döndürüyoruz
        return JsonConvert.DeserializeObject<List<TResponse>>(response.ToString());
    }
}
