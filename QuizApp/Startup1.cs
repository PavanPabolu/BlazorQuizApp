using Microsoft.Extensions.DependencyInjection;
using QuizApp.Data;

namespace QuizApp
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
            services.AddSingleton<QuizService>();
        }
    }
}