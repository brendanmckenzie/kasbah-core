using System;

namespace Kasbah.Core.Redis
{
    public class RedisCacheProvider : ICacheProvider
    {
        #region Public Methods

        public bool Exists(string key)
        {
            throw new NotImplementedException();
        }

        public object Get(string key, Type type)
        {
            throw new NotImplementedException();
        }

        public T Get<T>(string key)
        {
            throw new NotImplementedException();
        }

        public T GetOrSet<T>(string key, Func<T> generator)
        {
            throw new NotImplementedException();
        }

        public void Invalidate(string key)
        {
            throw new NotImplementedException();
        }

        public void Set(string key, object data)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}