using BlazorSSR;
using BlazorSSR.Pages;
using Microsoft.AspNetCore.Components.Endpoints;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddServerComponents();
builder.Services.AddControllers();

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

app.MapRazorComponents<App>();
app.MapDefaultControllerRoute();
app.Map("/route", () => new RazorComponentResult<Home>(new { Message = "Hello from route!" }));

app.Run();
