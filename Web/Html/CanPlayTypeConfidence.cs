using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Html
{
    /// <summary>
    /// </summary>
    /// <reference>http://dev.w3.org/html5/pf-summary/video.html#dom-navigator-canplaytype</reference>
    [NamedValues]
    [IgnoreNamespace]
    [Imported(ObeysTypeSystem = true)]
    public enum CanPlayTypeConfidence
    {
        [ScriptName("")]
        Cannot,

        [ScriptName("probably")]
        Probably,

        [ScriptName("maybe")]
        Maybe
    }
}
