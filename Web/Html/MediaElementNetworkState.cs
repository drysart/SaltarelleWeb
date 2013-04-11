using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Html
{
    /// <summary>
    /// </summary>
    /// <reference>http://dev.w3.org/html5/pf-summary/video.html#dom-media-networkstate</reference>
    [NumericValues]
    [Imported, IgnoreNamespace]
    public enum MediaElementNetworkState : ushort
    {
        Empty = 0,
        Idle = 1,
        Loading = 2,
        Loaded = 3,
        NoSource = 4
    }
}
