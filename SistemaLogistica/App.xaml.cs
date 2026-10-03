using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SistemaLogistica.Infraesctrutura.Data;
using System.IO;
using System.Windows;

namespace SistemaLogistica
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static InventarioDbContext Db { get; private set; } = null!;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
           

            var connectionString = configuration
                .GetConnectionString("DefaultConnection");

            var options = new DbContextOptionsBuilder<InventarioDbContext>()
                .UseSqlServer(connectionString)
                .Options;
            Db = new InventarioDbContext(options);

        }

    }
}
