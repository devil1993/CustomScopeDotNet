﻿using Microsoft.Extensions.DependencyInjection;
using System;

namespace NonAspNetScopedDependency
{
    public class ScopedProvider
    {
        private static IServiceProvider _provider;
        private static readonly object _slock = new object();


        static ScopedProvider()
        {
            if (_provider == null)
            {
                lock (_slock)
                {
                    if (_provider == null)
                    {
                        ServiceCollection coll = GetServiceCollection();

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

        public static IServiceScope CreateScope()
        {
            return _provider.CreateScope();
        }
    }
}
