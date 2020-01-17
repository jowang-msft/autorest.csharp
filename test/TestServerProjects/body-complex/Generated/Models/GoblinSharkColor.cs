// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;

namespace body_complex.Models
{
    /// <summary> Colors possible. </summary>
    public readonly partial struct GoblinSharkColor : IEquatable<GoblinSharkColor>
    {
        private readonly string? _value;

        /// <summary> Determines if two <see cref="GoblinSharkColor"/> values are the same. </summary>
        public GoblinSharkColor(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PinkValue = "pink";
        private const string GrayValue = "gray";
        private const string BrownValue = "brown";
        private const string REDValue = "RED";
        private const string RedValue = "red";

        /// <summary> pink. </summary>
        public static GoblinSharkColor Pink { get; } = new GoblinSharkColor(PinkValue);
        /// <summary> gray. </summary>
        public static GoblinSharkColor Gray { get; } = new GoblinSharkColor(GrayValue);
        /// <summary> brown. </summary>
        public static GoblinSharkColor Brown { get; } = new GoblinSharkColor(BrownValue);
        /// <summary> RED. </summary>
        public static GoblinSharkColor RED { get; } = new GoblinSharkColor(REDValue);
        /// <summary> red. </summary>
        public static GoblinSharkColor Red { get; } = new GoblinSharkColor(RedValue);
        /// <summary> Determines if two <see cref="GoblinSharkColor"/> values are the same. </summary>
        public static bool operator ==(GoblinSharkColor left, GoblinSharkColor right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GoblinSharkColor"/> values are not the same. </summary>
        public static bool operator !=(GoblinSharkColor left, GoblinSharkColor right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="GoblinSharkColor"/>. </summary>
        public static implicit operator GoblinSharkColor(string value) => new GoblinSharkColor(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object? obj) => obj is GoblinSharkColor other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GoblinSharkColor other) => string.Equals(_value, other._value, StringComparison.Ordinal);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string? ToString() => _value;
    }
}
