using System;

namespace Kasbah.Core
{
    public interface ICacheProvider
    {
        #region Public Methods

        bool Exists(string key);

        object Get(string key, Type type);

        T Get<T>(string key);

        T GetOrSet<T>(string key, Func<T> generator);

        void Invalidate(string key);

        void Set(string key, object data);

        #endregion
    }
}