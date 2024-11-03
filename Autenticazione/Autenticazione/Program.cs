using Autenticazione.Context;
using Autenticazione.Repos;
using Autenticazione.Services;
using Microsoft.EntityFrameworkCore;

namespace Autenticazione
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);



            // Add services to the container.
            builder.Services.AddRazorPages();

            #region DEBUG-RELEASE

#if DEBUG
            builder.Services.AddDbContext<AutenticazioneContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseTest"))
                );


#else
            builder.Services.AddDbContext<AutenticazioneContext>(
                options => options.UseSqlServer(builder.Configuration.GetConnectionString("DatabaseProd"))
                );
#endif

            #endregion

            builder.Services.AddScoped<AmministratoreRepo>();
            builder.Services.AddScoped<UtenteRepo>();

            builder.Services.AddScoped<AmministratoreServices>();

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

            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}
