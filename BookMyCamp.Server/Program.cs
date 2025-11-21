using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Identity.Web;
using Microsoft.Identity.Abstractions;
using Microsoft.Identity.Web.Resource;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Repositories;
using Domain;
using Application.Services;
using Application.ServiceInterfaces;
using Application.RepositoryInterfaces;
using Infrastructure;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Options;

namespace BookMyCamp.Server;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        //DBContext Injection
        builder.Services.AddDbContext<BookMyCampDbContext>();

        //Service Injection
        builder.Services.AddScoped<IAddOnLineService, AddOnLineService>();
        builder.Services.AddScoped<IAddOnService, AddOnService>();
        builder.Services.AddScoped<IBookingService, BookingService>();
        builder.Services.AddScoped<IEmployeeLanguageService, EmployeeLanguageService>();
        builder.Services.AddScoped<IEmployeeService, EmployeeService>();
        builder.Services.AddScoped<IFacilityService, FacilityService>();
        builder.Services.AddScoped<IGuestService, GuestService>();
        builder.Services.AddScoped<IInvoiceService, InvoiceService>();
        builder.Services.AddScoped<ILanguageService, LanguageService>();
        builder.Services.AddScoped<ILogInService, LogInService>();
        builder.Services.AddScoped<IPasswordHasherService, PasswordHasherService>();
        builder.Services.AddScoped<IResourceService, ResourceService>();

        //Repository Injection
        builder.Services.AddScoped<IAddOnLineRepository, AddOnLineRepository>();
        builder.Services.AddScoped<IAddOnRepository, AddOnRepository>();
        builder.Services.AddScoped<IBookingRepository, BookingRepository>();
        builder.Services.AddScoped<IEmployeeLanguageRepository, EmployeeLanguageRepository>();
        builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        builder.Services.AddScoped<IFacilityRepository, FacilityRepository>();
        builder.Services.AddScoped<IInvoiceRepository, InvoiceRepository>();
        builder.Services.AddScoped<ILanguageRepository, LanguageRepository>();
        builder.Services.AddScoped<IResourceRepository, ResourceRepository>();
        builder.Services.AddScoped<ITempUserRepository, TempUserRepository>();
        builder.Services.AddScoped<IUserRepository, UserRepository>();

        builder.Services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
        })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = false,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = builder.Configuration["Jwt:Issuer"],
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]!))
                };
            });

        builder.Services.AddAuthorization(options =>
        {
            options.AddPolicy("AdminPolicy", policy => policy.RequireRole("Admin"));
            options.AddPolicy("EmployeePolicy", policy => policy.RequireRole("Employee"));
            options.AddPolicy("UserPolicy", policy => policy.RequireRole("User"));
        });

        builder.Services.AddScoped(sp =>
        {
            var navigationManager = sp.GetRequiredService<NavigationManager>();
            return new HttpClient
            {
                BaseAddress = new Uri(navigationManager.BaseUri)
            };
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
