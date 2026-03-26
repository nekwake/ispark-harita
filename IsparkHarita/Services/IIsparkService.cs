using IsparkHarita.Models;
namespace IsparkHarita.Services;

public interface IIsparkService
{
    Task<List<Otopark>> GetOtoparklarAsync();
    Task<OtoparkDetay?> GetOtoparkDetayAsync(int id);
}