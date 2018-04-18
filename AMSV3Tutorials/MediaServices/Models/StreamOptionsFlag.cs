// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for StreamOptionsFlag.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StreamOptionsFlag
    {
        [EnumMember(Value = "Default")]
        Default,
        [EnumMember(Value = "LowLatency")]
        LowLatency
    }
    internal static class StreamOptionsFlagEnumExtension
    {
        internal static string ToSerializedValue(this StreamOptionsFlag? value)
        {
            return value == null ? null : ((StreamOptionsFlag)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this StreamOptionsFlag value)
        {
            switch( value )
            {
                case StreamOptionsFlag.Default:
                    return "Default";
                case StreamOptionsFlag.LowLatency:
                    return "LowLatency";
            }
            return null;
        }

        internal static StreamOptionsFlag? ParseStreamOptionsFlag(this string value)
        {
            switch( value )
            {
                case "Default":
                    return StreamOptionsFlag.Default;
                case "LowLatency":
                    return StreamOptionsFlag.LowLatency;
            }
            return null;
        }
    }
}
