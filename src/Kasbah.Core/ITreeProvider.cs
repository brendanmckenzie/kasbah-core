using System;
using System.Collections.Generic;
using Kasbah.Core.Models.Tree;

namespace Kasbah.Core
{
    public interface ITreeProvider
    {
        #region Public Methods

        Node CreateNode(Guid? parent, string alias);

        NodeVersion<TContent> CreateVersion<TContent>(Guid id, TContent content);

        void DeleteNode(Guid id);

        Node GetById(Guid id);

        Node GetByPath(string path);

        Node GetByPath(IEnumerable<string> path);

        NodeVersion<TContent> GetVersion<TContent>(Guid id, Guid version);

        IEnumerable<NodeVersion> ListVersions(Guid id);

        void PublishVersion(Guid id, Guid version);

        void RealiasNode(Guid id, string alias);

        void UnpublishNode(Guid id);

        IEnumerable<Node> GetChildren(Guid? id);

        #endregion
    }
}