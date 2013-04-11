using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Html
{
    /// <summary>
    /// </summary>
    /// <reference>http://dev.w3.org/html5/pf-summary/video.html#timeranges</reference>
    [IgnoreNamespace, Imported]
    public class TimeRanges
    {
        private TimeRanges()
        {
        }

        [IntrinsicProperty]
        public long Length { get; private set; }

        public double Start(long index)
        {
            return 0;
        }

        public double End(long index)
        {
            return 0;
        }
    }
}
