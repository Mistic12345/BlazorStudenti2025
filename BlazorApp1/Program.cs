using BlazorApp1.Components;
using BlazorApp1.Data;
using BlazorApp1.Services.Interfaces;
using BlazorApp1.Services.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

var conn = builder.Configuration.GetConnectionString("strConnection")
    ?? throw new InvalidOperationException("Connection string 'strConnection' not a found");

builder.Services.AddDbContext<WebAppContext>(options =>
options.UseSqlServer(conn));

builder.Services.AddScoped<IStudentiService, StudentiService>();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
