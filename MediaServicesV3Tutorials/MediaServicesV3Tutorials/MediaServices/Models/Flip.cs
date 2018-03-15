// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for Flip.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(FlipConverter))]
    public struct Flip : System.IEquatable<Flip>
    {
        private Flip(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// Do not flip the video.
        /// </summary>
        public static readonly Flip None = "None";

        /// <summary>
        /// Flip the video horizontally.
        /// </summary>
        public static readonly Flip Horizontal = "Horizontal";

        /// <summary>
        /// Flip the video vertically
        /// </summary>
        public static readonly Flip Vertical = "Vertical";


        /// <summary>
        /// Underlying value of enum Flip
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for Flip
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type Flip
        /// </summary>
        public bool Equals(Flip e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to Flip
        /// </summary>
        public static implicit operator Flip(string value)
        {
            return new Flip(value);
        }

        /// <summary>
        /// Implicit operator to convert Flip to string
        /// </summary>
        public static implicit operator string(Flip e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum Flip
        /// </summary>
        public static bool operator == (Flip e1, Flip e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum Flip
        /// </summary>
        public static bool operator != (Flip e1, Flip e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for Flip
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is Flip && Equals((Flip)obj);
        }

        /// <summary>
        /// Returns for hashCode Flip
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
