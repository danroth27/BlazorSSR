using BlazorSSR.Data;
using BlazorSSR.Shared;
using Microsoft.AspNetCore.Components.Endpoints;
using Index = BlazorSSR.Pages.Index;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents();
builder.Services.AddControllers();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapRazorComponents<MainLayout>();

app.MapDefaultControllerRoute();

app.Map("/route", () => new RazorComponentResult<Index>(new { Message = "Hello from route!"}));

app.Run();
