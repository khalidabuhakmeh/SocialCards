using System;
using System.Linq;
using System.Net;
using System.Web;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PlaywrightSharp;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Server.UseUrls($"https://{IPAddress.Loopback}:0");

var app = builder.Build();
app.MapRazorPages();

await app.StartAsync();
var port = new Uri(app.Addresses.First(url => url.StartsWith("https"))).Port;
var url = $"https://localhost:{port}/";

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