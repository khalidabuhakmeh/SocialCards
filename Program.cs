using System.Linq;
using System.Web;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PlaywrightSharp;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

var app = builder.Build();
app.MapRazorPages();

await app.StartAsync();
var url = app.Addresses.FirstOrDefault(url => url.StartsWith("https"));

var title = args[0];
var background = HttpUtility.UrlEncode(args[1]);
var slugify = new Slugify.SlugHelper();

// playwright
var playwright = await Playwright.CreateAsync();
await using var browser = await playwright.Chromium.LaunchAsync();
var page = await browser.NewPageAsync( new ViewportSize {
    Width = 1600, 
    Height = 1000
  }
);

await page.GoToAsync($"{url}?title={title}&bg={background}");
await page.ScreenshotAsync($"{slugify.GenerateSlug(title)}.png");

var lifetime = app.Services.GetService<IHostLifetime>() as IDisposable;
lifetime?.Dispose();