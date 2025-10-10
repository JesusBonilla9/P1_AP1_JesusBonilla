using P1_AP1_JesusBonilla.Components;
using Microsoft.EntityFrameworkCore;
using P1_AP1_JesusBonilla.DAL;
using P1_AP1_JesusBonilla.Services;
namespace P1_AP1_JesusBonilla;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents();
        var ConexionString = builder.Configuration.GetConnectionString("ConStr");
        builder.Services.AddDbContextFactory<Contexto>(options => options.UseSqlite(ConexionString));
        builder.Services.AddScoped<EntradasHuacalesServices>();
        builder.Services.AddBlazorBootstrap();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseAntiforgery();

        app.MapStaticAssets();
        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();

        app.Run();
    }
}
