using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kasbah.Core.Models.Tree
{
    public class NodeVersion
    {
    }

    public class NodeVersion<TContent>
    {
        public TContent Content { get; set; }
    }
}
