// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtAcronymMapping.Models
{
    /// <summary>
    /// The SubResourceReadOnly.
    /// Serialized Name: SubResourceReadOnly
    /// </summary>
    public partial class SubResourceReadOnly
    {
        /// <summary> Initializes a new instance of <see cref="SubResourceReadOnly"/>. </summary>
        public SubResourceReadOnly()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SubResourceReadOnly"/>. </summary>
        /// <param name="id">
        /// Resource Id
        /// Serialized Name: SubResourceReadOnly.id
        /// </param>
        internal SubResourceReadOnly(string id)
        {
            Id = id;
        }

        /// <summary>
        /// Resource Id
        /// Serialized Name: SubResourceReadOnly.id
        /// </summary>
        public string Id { get; }
    }
}