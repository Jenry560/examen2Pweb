using Microsoft.EntityFrameworkCore;
using ParcialDosWeb.Components;
using ParcialDosWeb.Models;

//Jenry Sanchez 2023-1080

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddDbContext<ParcialDosContext>(option => option.UseSqlServer("Data Source=DESKTOP-NDORDVA\\SQLEXPRESS;Initial Catalog=ParcialDos;Integrated Security=True;TrustServerCertificate=True;"));


var app = builder.Build();

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
