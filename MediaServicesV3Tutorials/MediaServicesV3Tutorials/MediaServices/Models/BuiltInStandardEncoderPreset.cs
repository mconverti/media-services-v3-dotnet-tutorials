// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Preset to use Media Encoder Standard (MES) with a built in named
    /// preset.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.BuiltInStandardEncoderPreset")]
    public partial class BuiltInStandardEncoderPreset : Preset
    {
        /// <summary>
        /// Initializes a new instance of the BuiltInStandardEncoderPreset
        /// class.
        /// </summary>
        public BuiltInStandardEncoderPreset()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BuiltInStandardEncoderPreset
        /// class.
        /// </summary>
        /// <param name="presetName">Gets or sets the built in preset to use.
        /// Possible values include: 'AdaptiveStreaming',
        /// 'ContentAdaptiveMultipleBitrateMP4', 'AACGoodQualityAudio',
        /// 'H264MultipleBitrate1080p', 'H264MultipleBitrate720p',
        /// 'SaasMultipleBitrate', 'SaasProxy', 'SaaSThumbnail'</param>
        public BuiltInStandardEncoderPreset(EncoderNamedPreset presetName)
        {
            PresetName = presetName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the built in preset to use. Possible values include:
        /// 'AdaptiveStreaming', 'ContentAdaptiveMultipleBitrateMP4',
        /// 'AACGoodQualityAudio', 'H264MultipleBitrate1080p',
        /// 'H264MultipleBitrate720p', 'SaasMultipleBitrate', 'SaasProxy',
        /// 'SaaSThumbnail'
        /// </summary>
        [JsonProperty(PropertyName = "presetName")]
        public EncoderNamedPreset PresetName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}