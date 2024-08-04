using BaseDatos;
using Interfaces;
using Implementaciones;

namespace CrudPolizas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddSingleton(new Conexion(builder.Configuration.GetConnectionString("Conexion")));
            builder.Services.AddScoped<IPoliza,PolizaImplementacion>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Poliza}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
