using Microsoft.AspNetCore.Mvc;
using IsparkHarita.Services;
using IsparkHarita.Models;

namespace IsparkHarita.Controllers;

public class HomeController : Controller
{
    private readonly IIsparkService _isparkService;

    // Service'i burada içeri alıyoruz (Dependency Injection)
    public HomeController(IIsparkService isparkService)
    {
        _isparkService = isparkService;
    }

    // ANA SAYFA: Landing page
    public IActionResult Index()
    {
        return View();
    }

    // HARİTA SAYFASI: Tüm otoparkları çeker
    public async Task<IActionResult> Harita()
    {
        var otoparklar = await _isparkService.GetOtoparklarAsync();
        return View(otoparklar);
    }

    // DETAY SAYFASI: Tek bir otoparkın poligon ve detaylarını çeker
    public async Task<IActionResult> Detay(int id)
    {
        var detay = await _isparkService.GetOtoparkDetayAsync(id);
        
        if (detay == null)
            return NotFound();

        return View(detay);
    }

    // HAKKINDA SAYFASI
    public IActionResult About()
    {
        return View();
    }

    // İSTATİSTİKLER SAYFASI
    public async Task<IActionResult> Istatistikler()
    {
        var otoparklar = await _isparkService.GetOtoparklarAsync();
        return View(otoparklar);
    }
}