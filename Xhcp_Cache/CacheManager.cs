using Microsoft.Extensions.Caching.Redis;
using Newtonsoft.Json;
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Xhcp_Core.Cache;
using Xhcp_Entity.Common.ResultModel;

namespace Xhcp_Cache
{
    public class CacheManager : ICache
    {
        private RedisCache cache;
        public CacheManager(RedisCache cache)
        {
            this.cache = cache;
        }
        public OpreationResult Clear()
        {
            throw new NotImplementedException();
        }

        public OpreationResult Clear(string key)
        {
            try
            {
                cache.Remove(key);
                return OpreationResult.Init(OpreationResultType.Success);
            }
            catch (Exception e)
            {
                return OpreationResult.Init(OpreationResultType.Error, e.Message);
            }
        }

        public OpreationResult<T> Get<T>(string key) where T : class
        {
            try
            {
                var result = cache.Get(key);
                var temp = JsonConvert.SerializeObject(result);
                return OpreationResult<T>.Init(OpreationResultType.Success, JsonConvert.DeserializeObject<T>(temp));
            }
            catch (Exception e)
            {
                return OpreationResult<T>.Init(OpreationResultType.Error, default(T), e.Message);
            }
        }

        public OpreationResult Set<T>(T obj, string key)
        {
            throw new NotImplementedException();
        }

        public OpreationResult Set<T>(T obj, string key, TimeSpan timeSpan)
        {
            throw new NotImplementedException();
        }

        public OpreationResult Update<T>(T obj, string key)
        {
            throw new NotImplementedException();
        }

        public OpreationResult Update<T>(T obj, string key, TimeSpan timeSpan)
        {
            throw new NotImplementedException();
        }
    }
}
