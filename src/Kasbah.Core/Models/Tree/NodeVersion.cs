namespace Kasbah.Core.Models.Tree
{
    public class NodeVersion
    {
    }

    public class NodeVersion<TContent>
    {
        #region Public Properties

        public TContent Content { get; set; }

        #endregion
    }
}