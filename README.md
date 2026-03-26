# Ispark Harita - IBB Otoparklar

Istanbul Buyuksehir Belediyesi (IBB) otopark verilerini harita uzerinde gosteren ASP.NET Core MVC uygulamasi.

## Canli Demo

- Uygulama: [ispark-harita-production.up.railway.app](https://ispark-harita-production.up.railway.app/)

## Ozellikler

- Istanbul genelindeki IBB otoparklarini harita uzerinde gosterme
- Anlik bos kapasite ve toplam kapasite bilgilerini listeleme
- Otopark detay sayfasi (adres, calisma saatleri, tarife vb.)
- Istatistikler sayfasi (kapasite ve doluluk odakli ozetler)
- Basit, hizli ve mobil uyumlu arayuz

## Kullanilan Teknolojiler

- ASP.NET Core MVC (`net10.0`)
- C#
- Razor Views
- Bootstrap
- jQuery

## Proje Yapisi

```text
IsparkHarita/
|- Controllers/
|- Models/
|- Services/
|- Views/
|- wwwroot/
|- Program.cs
|- IsparkHarita.csproj
```

## Lokal Calistirma

Onkosul:

- .NET SDK 10.x

Komutlar:

```bash
dotnet restore IsparkHarita/IsparkHarita.csproj
dotnet run --project IsparkHarita/IsparkHarita.csproj
```

Varsayilan gelistirme adresleri `launchSettings.json` icindeki profillere gore acilir.

## Publish

```bash
dotnet publish IsparkHarita/IsparkHarita.csproj -c Release -o out
dotnet out/IsparkHarita.dll
```

## Railway Deploy Notlari

Bu repoda Dockerfile oldugu icin Railway uzerinde Docker tabanli deploy en sorunsuz secenektir.

- Port: `8080`
- Ortam degiskeni: `ASPNETCORE_URLS=http://0.0.0.0:8080`
- Ortam degiskeni: `ASPNETCORE_ENVIRONMENT=Production`

## Ekran Goruntuleri

Repo icerisinde ornek goruntuler:

- `IsparkHarita/wwwroot/images/landing/screenshot-map.png`
- `IsparkHarita/wwwroot/images/landing/screenshot-filters.png`
- `IsparkHarita/wwwroot/images/landing/screenshot-stats.png`

## Veri Kaynagi

Uygulama verileri IBB Ispark API uzerinden alinir.

## Lisans

Bu proje icin henuz bir lisans dosyasi tanimlanmamistir.

