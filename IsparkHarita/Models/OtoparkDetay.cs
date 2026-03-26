namespace IsparkHarita.Models;

public class OtoparkDetay
{
    public string locationName { get; set; } = string.Empty;
    public int parkID { get; set; }
    public string lat { get; set; } = string.Empty;
    public string lng { get; set; } = string.Empty;
    public int capacity { get; set; }
    public int emptyCapacity { get; set; }
    public string workHours { get; set; } = string.Empty;
    public string district { get; set; } = string.Empty;
    public string address { get; set; } = string.Empty;
    public string areaPolygon { get; set; } = string.Empty;
    public string tariff { get; set; } = string.Empty;

    // HATA VEREN KRİTİK ALANLAR
    // object yaparak JSON okuyucunun itiraz etmesini engelliyoruz
    public object? monthlyFee { get; set; } 
    public object? freeTime { get; set; }
}