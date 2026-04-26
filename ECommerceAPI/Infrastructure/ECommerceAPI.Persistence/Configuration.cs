using Microsoft.Extensions.Configuration;

namespace ECommerceAPI.Persistence
{
    static class Configuration
    {
        public static string ConnectionString
        { 
            get 
            {
                ConfigurationManager configuration = new ConfigurationManager();
                configuration.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/ECommerceAPI.API"));
                configuration.AddJsonFile("appsettings.json");
                return configuration.GetConnectionString("PostgreSQL")!;
            }
        }
    }
}
