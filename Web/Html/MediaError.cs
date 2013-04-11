using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Html
{
    /// <summary>
    /// </summary>
    /// <reference>http://dev.w3.org/html5/pf-summary/video.html#mediaerror</reference>
    [IgnoreNamespace, Imported]
    public class MediaError
    {
        private MediaError()
        {
        }

        [IntrinsicProperty]
        public MediaErrorCode Code { get; private set; }
    }
}
