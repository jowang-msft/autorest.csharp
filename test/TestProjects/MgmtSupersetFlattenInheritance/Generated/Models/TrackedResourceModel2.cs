// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace MgmtSupersetFlattenInheritance.Models
{
    /// <summary> TrackedResource with flatten properties, but the id comes from flattened properties, therefore this should not be a resource. </summary>
    public partial class TrackedResourceModel2 : TrackedResourceData
    {
        /// <summary> Initializes a new instance of TrackedResourceModel2. </summary>
        /// <param name="location"> The location. </param>
        public TrackedResourceModel2(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of TrackedResourceModel2. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="foo"></param>
        /// <param name="bar"></param>
        /// <param name="fooPropertiesFoo"></param>
        internal TrackedResourceModel2(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string foo, string bar, string fooPropertiesFoo) : base(id, name, resourceType, systemData, tags, location)
        {
            Foo = foo;
            Bar = bar;
            FooPropertiesFoo = fooPropertiesFoo;
        }

        /// <summary> Gets or sets the foo. </summary>
        public string Foo { get; set; }
        /// <summary> Gets or sets the bar. </summary>
        public string Bar { get; set; }
        /// <summary> Gets or sets the foo properties foo. </summary>
        public string FooPropertiesFoo { get; set; }
    }
}