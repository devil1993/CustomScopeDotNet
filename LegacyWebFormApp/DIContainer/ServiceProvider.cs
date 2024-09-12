using System;
using System.Security.Policy;
using BusinessLogics;
using LegacyWebFormApp.Core;
using LegacyWebFormApp.DataAccess;
using LegacyWebFormApp.DataAccess.Adapters;
using Microsoft.Extensions.DependencyInjection;

namespace LegacyWebFormApp.DIContainer
{
    public class ServiceProvider
    {
        private static IServiceProvider _provider;
        private static readonly object _slock = new object();


        static ServiceProvider()
        {
            if (_provider == null)
            {
                lock (_slock)
                {
                    if (_provider == null)
                    {
                        ServiceCollection coll = GetServiceCollection();

                        coll.AddTransient<ITenantDataAccess, TenantDataAccessAdapter>();
                        coll.AddTransient<IUserDataAccess, UserDataAccessAdapter>();

                        coll.AddTransient<UserDashboardProvider>();
                        coll.AddScoped<LegacyStateWrapper>();
                        //coll.AddScoped<LegacyState, LegacyStateWrapper>();

                        _provider = coll.BuildServiceProvider();
                    }
                }
            }
        }

        private static ServiceCollection GetServiceCollection()
        {
            ServiceCollection coll = new ServiceCollection();

            return coll;
        }

        public static T GetRequiredService<T>(){
            return _provider.GetRequiredService<T>();
        }

        public static IServiceScope GetServiceScope()
        {
            return _provider.CreateScope();
        }
    }
}