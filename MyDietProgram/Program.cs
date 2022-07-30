using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyDietProgram.Classes;
using System.Data.SqlClient;

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
                    options.UseSqlServer(@"Server=.; Database=DietDB_DEG; Trusted_Connection=True");
                });
            });

            var host = builder.Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;

                var context = services.GetRequiredService<Context>();
                context.Database.EnsureCreated();
                Application.Run(new LoginForm(context));

            }
           
        }
    }
}