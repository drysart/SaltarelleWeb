using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Html
{
    /// <summary>
    /// </summary>
    /// <reference>http://dev.w3.org/html5/pf-summary/video.html#htmlmediaelement</reference>
    [IgnoreNamespace]
    [ScriptName("HTMLMediaElement")]
    [Imported(ObeysTypeSystem = true)]
    public class MediaElement : Element
    {
        [NonScriptable]
        protected MediaElement()
        {
        }

        [IntrinsicProperty]
        public MediaError Error { get; private set; }

        [IntrinsicProperty]
        public string Src { get; set; }

        [IntrinsicProperty]
        public string CurrentSrc { get; private set; }
  
        [IntrinsicProperty]
        public MediaElementNetworkState NetworkState { get; private set; }

        [IntrinsicProperty]
        [ScriptName("autobuffer")]
        public bool AutoBuffer { get; set; }
        
        [IntrinsicProperty]
        public TimeRanges Buffered { get; private set; }
  
        public void Load()
        {
        }

        public CanPlayTypeConfidence CanPlayType(string type)
        {
            return CanPlayTypeConfidence.Cannot;
        }

        [IntrinsicProperty]
        public MediaElementReadyState ReadyState { get; private set; }

        [IntrinsicProperty]
        public bool Seeking { get; private set; }

        [IntrinsicProperty]
        public double CurrentTime { get; set; }

        [IntrinsicProperty]
        public double StartTime { get; private set; }

        [IntrinsicProperty]
        public double Duration { get; private set; }

        [IntrinsicProperty]
        public bool Paused { get; private set; }

        [IntrinsicProperty]
        public double DefaultPlaybackRate { get; set; }

        [IntrinsicProperty]
        public double PlaybackRate { get; set; }

        [IntrinsicProperty]
        public TimeRanges Played { get; private set; }

        [IntrinsicProperty]
        public TimeRanges Seekable { get; private set; }

        [IntrinsicProperty]
        public bool Ended { get; private set; }

        [IntrinsicProperty]
        public bool Autoplay { get; set; }

        [IntrinsicProperty]
        public bool Loop { get; set; }

        public void Play()
        {
        }

        public void Pause()
        {
        }

        public void AddCueRange(string className, string id, double start, double end,
            bool pauseOnExit, Action<string> enterCallback, Action<string> exitCallback)
        {
        }

        public void RemoveCueRanges(string className)
        {
        }

        [IntrinsicProperty]
        public bool Controls { get; set; }

        [IntrinsicProperty]
        public double Volume { get; set; }

        [IntrinsicProperty]
        public bool Muted { get; set; }
    }
}
