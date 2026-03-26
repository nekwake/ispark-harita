namespace IsparkHarita.Models;

public class Otopark
{
    public int parkID { get; set; }
    public string parkName { get; set; } = string.Empty;
    public string lat { get; set; } = string.Empty;
    public string lng { get; set; } = string.Empty;
    public int capacity { get; set; }
    public int emptyCapacity { get; set; }
    public string areaPolygon { get; set; } = string.Empty;
    public string district { get; set; } = string.Empty;
    public double Latitude => double.Parse(lat, System.Globalization.CultureInfo.InvariantCulture);
    public double Longitude => double.Parse(lng, System.Globalization.CultureInfo.InvariantCulture);
}