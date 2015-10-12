using System;
using System.Collections.Generic;
using Kasbah.Core.Models.Tree;

namespace Kasbah.Core.Providers.Tree
{
    public class ReadOnlyTreeProvider : ITreeProvider
    {
        #region Public Methods

        #region Unsupported methods

        public Node CreateNode(Guid? parent, string alias)
        {
            throw new NotSupportedException();
        }

        public NodeVersion<TContent> CreateVersion<TContent>(Guid id, TContent content)
        {
            throw new NotSupportedException();
        }

        public void DeleteNode(Guid id)
        {
            throw new NotSupportedException();
        }

        public void PublishVersion(Guid id, Guid version)
        {
            throw new NotSupportedException();
        }

        public void RealiasNode(Guid id, string alias)
        {
            throw new NotSupportedException();
        }

        public void UnpublishNode(Guid id)
        {
            throw new NotSupportedException();
        }

        #endregion

        public Node GetById(Guid id)
        {
            throw new NotSupportedException();
        }

        public Node GetByPath(IEnumerable<string> path)
        {
            throw new NotSupportedException();
        }

        public Node GetByPath(string path)
        {
            throw new NotSupportedException();
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

        #endregion
    }
}