// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;

namespace AppConfiguration.Models.V10
{
    /// <summary> MISSING·SCHEMA-DESCRIPTION-CHOICE. </summary>
    public readonly partial struct Head6ItemsItem : IEquatable<Head6ItemsItem>
    {
        private readonly string? _value;

        /// <summary> Determines if two <see cref="Head6ItemsItem"/> values are the same. </summary>
        public Head6ItemsItem(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string KeyValue = "key";
        private const string LabelValue = "label";
        private const string ContentTypeValue = "content_type";
        private const string ValueValue = "value";
        private const string LastModifiedValue = "last_modified";
        private const string TagsValue = "tags";
        private const string LockedValue = "locked";
        private const string EtagValue = "etag";

        /// <summary> key. </summary>
        public static Head6ItemsItem Key { get; } = new Head6ItemsItem(KeyValue);
        /// <summary> label. </summary>
        public static Head6ItemsItem Label { get; } = new Head6ItemsItem(LabelValue);
        /// <summary> content_type. </summary>
        public static Head6ItemsItem ContentType { get; } = new Head6ItemsItem(ContentTypeValue);
        /// <summary> value. </summary>
        public static Head6ItemsItem Value { get; } = new Head6ItemsItem(ValueValue);
        /// <summary> last_modified. </summary>
        public static Head6ItemsItem LastModified { get; } = new Head6ItemsItem(LastModifiedValue);
        /// <summary> tags. </summary>
        public static Head6ItemsItem Tags { get; } = new Head6ItemsItem(TagsValue);
        /// <summary> locked. </summary>
        public static Head6ItemsItem Locked { get; } = new Head6ItemsItem(LockedValue);
        /// <summary> etag. </summary>
        public static Head6ItemsItem Etag { get; } = new Head6ItemsItem(EtagValue);
        /// <summary> Determines if two <see cref="Head6ItemsItem"/> values are the same. </summary>
        public static bool operator ==(Head6ItemsItem left, Head6ItemsItem right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Head6ItemsItem"/> values are not the same. </summary>
        public static bool operator !=(Head6ItemsItem left, Head6ItemsItem right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Head6ItemsItem"/>. </summary>
        public static implicit operator Head6ItemsItem(string value) => new Head6ItemsItem(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is Head6ItemsItem other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Head6ItemsItem other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string? ToString() => _value;
    }
}