using GUI.Client.Pages;
using GUI.Components;
using Application.ServiceInterfaces;
using Application.Services;

namespace GUI;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorComponents()
            .AddInteractiveServerComponents()
            .AddInteractiveWebAssemblyComponents();

        builder.WebHost.ConfigureKestrel((context, serverOptions) =>
        {
            serverOptions.ListenAnyIP(25001);
            serverOptions.ListenAnyIP(25002);
        });

        //DBContext Injection


        //Service Injection
        builder.Services.AddScoped<IAdminService, AdminService>();
        builder.Services.AddScoped<IBookingService, BookingService>();
        builder.Services.AddScoped<IGuestService, GuestService>();

        //Repository Injection


        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseWebAssemblyDebugging();
        }
        else
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();
        app.UseAntiforgery();

        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode()
            .AddInteractiveWebAssemblyRenderMode()
            .AddAdditionalAssemblies(typeof(Client._Imports).Assembly);

        app.Run();
    }
}
