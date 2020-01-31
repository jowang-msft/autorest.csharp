// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

#nullable disable

using System.Collections.Generic;

namespace xml_service.Models
{
    /// <summary> An enumeration of containers. </summary>
    public partial class ListContainersResponse
    {
        public string ServiceEndpoint { get; set; }
        public string Prefix { get; set; }
        public string Marker { get; set; }
        public int MaxResults { get; set; }
        public ICollection<Container> Containers { get; set; }
        public string NextMarker { get; set; }
    }
}
