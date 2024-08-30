using System.Security.Cryptography.X509Certificates;

namespace AppStructure
{
    public class Program
    {
        public static void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
        }
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            app.MapGet("{controller}/{action}/{id?}", () => "Hello World!");

            app.Run();
            
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller}/{action}/{id:int?}/{name:alpha?}"

                );
            
        }
    }
}
