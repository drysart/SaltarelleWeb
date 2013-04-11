using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Html
{
    /// <summary>
    /// </summary>
    /// <reference>http://dev.w3.org/html5/pf-summary/video.html#mediaerror</reference>
    [NumericValues]
    [IgnoreNamespace, Imported]
    public enum MediaErrorCode : ushort
    {
        Aborted = 1,
        Network = 2,
        Decode = 3,
        SrcNotSupported = 4
    }
}
