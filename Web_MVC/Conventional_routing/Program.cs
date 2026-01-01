using Microsoft.AspNetCore.Mvc;

namespace Conventional_routing
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.MapControllerRoute(

                name: "default",
                pattern: "{Controller=Demo}/{action=Index}/{id?}"

                );
            app.MapControllerRoute(

                name: "DAC",
                pattern: "{Controller=Admin}/{action=Index}/{nm?}"

                );
            app.MapControllerRoute(

                name: "DMC",
                pattern: "{Controller=Home}/{action=UserCredentials}/{unm}/{pwd}"

                );

            app.Run();
        }
    }
}
