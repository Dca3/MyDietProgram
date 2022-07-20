using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyDietProgram.Classes;

namespace MyDietProgram
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var builder = new HostBuilder().ConfigureServices((services) =>
            {
                services.AddDbContext<Context>(options =>
                {
                    options.UseSqlServer("Server=.;Database=Diet;User Id = sa;Password=123");
                });
            });

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;

                var context = services.GetRequiredService<Context>();
                Application.Run(new Form1(context));

            }
           
        }
    }
}