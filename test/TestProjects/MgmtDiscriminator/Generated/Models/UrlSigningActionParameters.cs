// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace MgmtDiscriminator.Models
{
    /// <summary> Defines the parameters for the Url Signing action. </summary>
    public partial class UrlSigningActionParameters
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="UrlSigningActionParameters"/>. </summary>
        /// <param name="typeName"></param>
        public UrlSigningActionParameters(UrlSigningActionParametersTypeName typeName)
        {
            TypeName = typeName;
            ParameterNameOverride = new ChangeTrackingList<UrlSigningParamIdentifier>();
        }

        /// <summary> Initializes a new instance of <see cref="UrlSigningActionParameters"/>. </summary>
        /// <param name="typeName"></param>
        /// <param name="algorithm"> Algorithm to use for URL signing. </param>
        /// <param name="parameterNameOverride"> Defines which query string parameters in the url to be considered for expires, key id etc. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UrlSigningActionParameters(UrlSigningActionParametersTypeName typeName, Algorithm? algorithm, IList<UrlSigningParamIdentifier> parameterNameOverride, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TypeName = typeName;
            Algorithm = algorithm;
            ParameterNameOverride = parameterNameOverride;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="UrlSigningActionParameters"/> for deserialization. </summary>
        internal UrlSigningActionParameters()
        {
        }

        /// <summary> Gets or sets the type name. </summary>
        public UrlSigningActionParametersTypeName TypeName { get; set; }
        /// <summary> Algorithm to use for URL signing. </summary>
        public Algorithm? Algorithm { get; set; }
        /// <summary> Defines which query string parameters in the url to be considered for expires, key id etc. </summary>
        public IList<UrlSigningParamIdentifier> ParameterNameOverride { get; }
    }
}
