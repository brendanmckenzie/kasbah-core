using System;
using System.Collections.Generic;
using Kasbah.Core.Models.Tree;

namespace Kasbah.Core.Redis
{
    public class RedisTreeProvider : ITreeProvider
    {
        #region Public Methods

        public Node CreateNode(Guid? parent, string alias)
        {
            throw new NotImplementedException();
        }

        public NodeVersion<TContent> CreateVersion<TContent>(Guid id, TContent content)
        {
            throw new NotImplementedException();
        }

        public void DeleteNode(Guid id)
        {
            throw new NotImplementedException();
        }

        public Node GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Node GetByPath(IEnumerable<string> path)
        {
            throw new NotImplementedException();
        }

        public Node GetByPath(string path)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Node> GetChildren(Guid? id)
        {
            throw new NotImplementedException();
        }

        public NodeVersion<TContent> GetVersion<TContent>(Guid id, Guid version)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NodeVersion> ListVersions(Guid id)
        {
            throw new NotImplementedException();
        }

        public void PublishVersion(Guid id, Guid version)
        {
            throw new NotImplementedException();
        }

        public void RealiasNode(Guid id, string alias)
        {
            throw new NotImplementedException();
        }

        public void UnpublishNode(Guid id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}