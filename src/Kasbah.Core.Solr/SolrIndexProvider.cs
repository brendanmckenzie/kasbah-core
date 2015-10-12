using System;
using System.Collections.Generic;
using Kasbah.Core.Models.Index;

namespace Kasbah.Core.Solr
{
    public class SolrIndexProvider : IIndexProvider
    {
        #region Public Methods

        public void AddOrUpdate(object content)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IndexEntry> Query(object query)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<IndexEntry> Query(string query)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}