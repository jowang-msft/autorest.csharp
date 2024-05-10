// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace _Type.Property.AdditionalProperties.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class TypePropertyAdditionalPropertiesModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="Models.WidgetData0"/>. </summary>
        /// <param name="kind"></param>
        /// <param name="fooProp"></param>
        /// <returns> A new <see cref="Models.WidgetData0"/> instance for mocking. </returns>
        public static WidgetData0 WidgetData0(WidgetData0Kind kind = default, string fooProp = null)
        {
            return new WidgetData0(kind, fooProp, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.WidgetData1"/>. </summary>
        /// <param name="kind"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns> A new <see cref="Models.WidgetData1"/> instance for mocking. </returns>
        public static WidgetData1 WidgetData1(WidgetData1Kind kind = default, DateTimeOffset start = default, DateTimeOffset? end = null)
        {
            return new WidgetData1(kind, start, end, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.WidgetData2"/>. </summary>
        /// <param name="kind"></param>
        /// <param name="start"></param>
        /// <returns> A new <see cref="Models.WidgetData2"/> instance for mocking. </returns>
        public static WidgetData2 WidgetData2(WidgetData2Kind kind = default, string start = null)
        {
            return new WidgetData2(kind, start, serializedAdditionalRawData: null);
        }
    }
}