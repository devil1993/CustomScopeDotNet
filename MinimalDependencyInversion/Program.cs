
using BusinessLogics;

namespace MinimalDependencyInversion
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddTransient<UserDashboardProvider>();
            builder.Services.AddTransient<IUserDataAccess, ModernUserDataAccess>();
            builder.Services.AddTransient<ITenantDataAccess, ModernTenantDataAccess>();


            var app = builder.Build();

            app.UseHttpsRedirection();

            app.MapGet("/UserDashboard/Welcome", (HttpContext httpContext, UserDashboardProvider udp) =>
            {
                return udp.GetWelcomeMessage();
            })
            .WithName("GetUserDashboardInfo")
            .WithOpenApi();

            app.Run();
        }
    }

    public class ModernTenantDataAccess : ITenantDataAccess
    {
        public TenantInfo GetCurrentTenantInformation()
        {
            // logic to fetch Tenant info from Tenant Micro Service
            return new TenantInfo();
        }
    }

    public class ModernUserDataAccess : IUserDataAccess
    {
        public string GetCurrentUserName()
        {
            // New logic to fetch user info - from database or User Micro Service
            return "Modern Dummy User";
        }
    }
}
