// AudioElement.cs
// Script#/Libraries/Web
// This source code is subject to terms and conditions of the Apache License, Version 2.0.
//

using System;
using System.Runtime.CompilerServices;

namespace System.Html 
{
    /// <summary>
    /// </summary>
    /// <reference>http://dev.w3.org/html5/pf-summary/Overview.html#audio</reference>
    [IgnoreNamespace]
	[ScriptName("HTMLAudioElement")]
    [Imported(ObeysTypeSystem = true)]
    public sealed class AudioElement : MediaElement 
    {
        [InlineCode("window.document.createElement('audio')")]
        public AudioElement() 
        {
        }
    }
}
