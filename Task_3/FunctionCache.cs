using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class FunctionCache<TKey, TResult>
    {
        public delegate TResult Func<TKey, TResult>(TKey key);

        private readonly Dictionary<TKey, CacheItem> cache = new Dictionary<TKey, CacheItem>();

        public TResult GetOrAdd(TKey key, Func<TKey, TResult> func, TimeSpan expiration)
        {
            if (cache.TryGetValue(key, out var cacheItem) && IsCacheItemValid(cacheItem, expiration))
            {
                return cacheItem.Value;
            }

            TResult result = func(key);
            cache[key] = new CacheItem(result, DateTime.Now.Add(expiration));
            return result;
        }

        private bool IsCacheItemValid(CacheItem cacheItem, TimeSpan expiration)
        {
            return DateTime.Now <= cacheItem.Expiration;
        }

        private class CacheItem
        {
            public TResult Value { get; }
            public DateTime Expiration { get; }

            public CacheItem(TResult value, DateTime expiration)
            {
                Value = value;
                Expiration = expiration;
            }
        }
    }
}
