// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for AacAudioProfile.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(AacAudioProfileConverter))]
    public struct AacAudioProfile : System.IEquatable<AacAudioProfile>
    {
        private AacAudioProfile(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        /// <summary>
        /// AAC Low complexity.
        /// </summary>
        public static readonly AacAudioProfile AacLc = "AacLc";

        /// <summary>
        /// HE AAC V1.
        /// </summary>
        public static readonly AacAudioProfile HeAacV1 = "HeAacV1";

        /// <summary>
        /// HE AAC v2.
        /// </summary>
        public static readonly AacAudioProfile HeAacV2 = "HeAacV2";


        /// <summary>
        /// Underlying value of enum AacAudioProfile
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for AacAudioProfile
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type AacAudioProfile
        /// </summary>
        public bool Equals(AacAudioProfile e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to AacAudioProfile
        /// </summary>
        public static implicit operator AacAudioProfile(string value)
        {
            return new AacAudioProfile(value);
        }

        /// <summary>
        /// Implicit operator to convert AacAudioProfile to string
        /// </summary>
        public static implicit operator string(AacAudioProfile e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum AacAudioProfile
        /// </summary>
        public static bool operator == (AacAudioProfile e1, AacAudioProfile e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum AacAudioProfile
        /// </summary>
        public static bool operator != (AacAudioProfile e1, AacAudioProfile e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for AacAudioProfile
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is AacAudioProfile && Equals((AacAudioProfile)obj);
        }

        /// <summary>
        /// Returns for hashCode AacAudioProfile
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
