using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using IsparkHarita.Models; // Modelleri tanıması için

namespace IsparkHarita.Services;

public class IsparkService : IIsparkService
{
    private readonly HttpClient _httpClient;
    public IsparkService(HttpClient httpClient) => _httpClient = httpClient;

    public async Task<List<Otopark>> GetOtoparklarAsync() => 
        await _httpClient.GetFromJsonAsync<List<Otopark>>("https://api.ibb.gov.tr/ispark/Park") ?? new List<Otopark>();

    public async Task<OtoparkDetay?> GetOtoparkDetayAsync(int id) {
        var options = new JsonSerializerOptions { NumberHandling = JsonNumberHandling.AllowReadingFromString };
        var list = await _httpClient.GetFromJsonAsync<List<OtoparkDetay>>($"https://api.ibb.gov.tr/ispark/ParkDetay?id={id}", options);
        return list?.FirstOrDefault();
    }
}