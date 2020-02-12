// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System;
using System.Collections.Generic;

namespace AppConfiguration.Models
{
    /// <summary> The KeyValue. </summary>
    public partial class KeyValue
    {
        public string Key { get; set; }
        public string Label { get; set; }
        public string ContentType { get; set; }
        public string Value { get; set; }
        public DateTimeOffset? LastModified { get; set; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> Tags { get; set; }
        public bool? Locked { get; set; }
        public string Etag { get; set; }
    }
}
