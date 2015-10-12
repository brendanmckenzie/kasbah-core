using System;
using System.Collections.Generic;
using Kasbah.Core.Models.Index;

namespace Kasbah.Core
{
    public interface IIndexProvider
    {
        #region Public Methods

        void AddOrUpdate(object content);

        IEnumerable<IndexEntry> Query(string query);

        IEnumerable<IndexEntry> Query(object query);

        void Remove(Guid id);

        #endregion
    }
}