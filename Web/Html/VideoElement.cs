using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Html
{
    /// <summary>
    /// </summary>
    /// <reference>http://dev.w3.org/html5/pf-summary/video.html#video</reference>
    [IgnoreNamespace]
    [ScriptName("HTMLVideoElement")]
    [Imported(ObeysTypeSystem = true)]
    public sealed class VideoElement : MediaElement
    {
        [InlineCode("window.document.createElement('video')")]
        public VideoElement()
        {
        }

        [IntrinsicProperty]
        public string Width { get; set; }

        [IntrinsicProperty]
        public string Height { get; set; }

        [IntrinsicProperty]
        public long VideoWidth { get; private set; }

        [IntrinsicProperty]
        public long VideoHeight { get; private set; }

        [IntrinsicProperty]
        public string Poster { get; set; }
    }
}
