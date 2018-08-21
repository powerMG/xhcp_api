using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Redis;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using Xhcp_Core.Cache;

namespace Xhcp_Cache
{
    public static class CacheRegistor
    {
        //public static IServiceCollection AddDistributedRedisCache(this IServiceCollection services, Action<CacheManager> setupAction)
        //{
        //    if (services == null)
        //    {
        //        throw new ArgumentNullException(nameof(services));
        //    }

        //    if (setupAction == null)
        //    {
        //        throw new ArgumentNullException(nameof(setupAction));
        //    }

        //    services.AddOptions();
        //    services.Configure(setupAction);
        //    // .net core DI容器的使用无非就是在容器中实例化接口，而接口的的实例化，是通过实例化接口的派生类(即以接口为父类的子类)...
        //    services.Add(ServiceDescriptor.Singleton<IDistributedCache, RedisCache>());

        //    return services;
        //}
        public static void AddCache(this IServiceCollection services, Action<RedisCacheOptions> setupAction)
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (setupAction == null)
            {
                throw new ArgumentNullException(nameof(setupAction));
            }
            services.AddDistributedRedisCache(setupAction);
            services.AddScoped<ICache, CacheManager>();

        }
    }
}
