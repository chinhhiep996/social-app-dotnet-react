using api.Services;
using Microsoft.Extensions.DependencyInjection;

namespace api.Helpers
{
    public static class Injector
    {
        public static void Register(this IServiceCollection services)
        {
            services.AddTransient<IUserService, UserService>();
            services.AddTransient(typeof(AppSettings));
        }
    }
}
