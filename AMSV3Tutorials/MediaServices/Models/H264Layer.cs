// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the settings to be used when encoding the input video into a
    /// desired output bitrate layer with the H264 video codec.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.H264Layer")]
    public partial class H264Layer : VideoLayer
    {
        /// <summary>
        /// Initializes a new instance of the H264Layer class.
        /// </summary>
        public H264Layer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the H264Layer class.
        /// </summary>
        /// <param name="width">Describes the width of the output video for
        /// this layer. The value can be absolute (in pixels) or relative (in
        /// percentage). For example 50% means the output video has half as
        /// many pixels in width as the input.</param>
        /// <param name="height">Describes the height of the output video for
        /// this layer. The value can be absolute (in pixels) or relative (in
        /// percentage). For example 50% means the output video has half as
        /// many pixels in height as the input.</param>
        /// <param name="label">Describes the alphanumeric label for this
        /// layer, which can be used in multiplexing different video and audio
        /// layers, or in naming the output file.</param>
        /// <param name="bitrate">Describes the average bitrate (in bits per
        /// second) at which to encode the input video when generating this
        /// layer. This is a required field.</param>
        /// <param name="maxBitrate">Describes the maximum bitrate (in bits per
        /// second), at which the VBV buffer should be assumed to refill. If
        /// not specified, defaults to the same value as bitrate.</param>
        /// <param name="bFrames">Describes the number of B-frames to be used
        /// when encoding this layer. If not specified, the encoder chooses an
        /// appropriate number based on the video Profile and Level.</param>
        /// <param name="frameRate">Describes the frame rate (in frames per
        /// second) at which to encode this layer. The value can be in the form
        /// of M/N where M and N are integers (e.g. 30000/1001), or in the form
        /// of a number (e.g. 30, or 29.97). The encoder enforces constraints
        /// on allowed frame rates based on the Profile and Level. If it is not
        /// specified, the encoder will use the same frame rate as the input
        /// video.</param>
        /// <param name="slices">Describes the number of slices to be used when
        /// encoding this layer. If not specified, default is zero, which means
        /// that encoder will use a single slice for each frame.</param>
        /// <param name="adaptiveBFrame">Determines whether or not adaptive
        /// B-frames are to be used when encoding this layer. If not specified,
        /// the encoder will turn it on whenever the video Profile permits its
        /// use.</param>
        /// <param name="profile">Describes which Profile of the H.264 standard
        /// should be used when encoding this layer. Default is Auto. Possible
        /// values include: 'Auto', 'Baseline', 'Main', 'High', 'High422',
        /// 'High444'</param>
        /// <param name="level">Describes which Level of the H.264 standard
        /// should be used when encoding this layer. The value can be Auto, or
        /// a number that matches the H264 Profile. If not specified, the
        /// default is Auto, which lets the encoder choose the Level that is
        /// appropriate for this layer.</param>
        /// <param name="bufferWindow">Describes the VBV buffer window length.
        /// The value should be in ISO 8601 format. The default is PT5S or 5
        /// seconds.</param>
        /// <param name="referenceFrames">Describes the number of reference
        /// frames to be used when encoding this layer. If not specified, the
        /// encoder determines an appropriate number based on the encoder
        /// complexity setting.</param>
        /// <param name="entropyMode">Describes the entropy mode to be used for
        /// this layer. If not specified, the encoder chooses the mode that is
        /// appropriate for the Profile and Level. Possible values include:
        /// 'Cabac', 'Cavlc'</param>
        public H264Layer(string width = default(string), string height = default(string), string label = default(string), int? bitrate = default(int?), int? maxBitrate = default(int?), int? bFrames = default(int?), string frameRate = default(string), int? slices = default(int?), bool? adaptiveBFrame = default(bool?), H264VideoProfile? profile = default(H264VideoProfile?), string level = default(string), System.TimeSpan? bufferWindow = default(System.TimeSpan?), int? referenceFrames = default(int?), EntropyMode? entropyMode = default(EntropyMode?))
            : base(width, height, label, bitrate, maxBitrate, bFrames, frameRate, slices, adaptiveBFrame)
        {
            Profile = profile;
            Level = level;
            BufferWindow = bufferWindow;
            ReferenceFrames = referenceFrames;
            EntropyMode = entropyMode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets describes which Profile of the H.264 standard should
        /// be used when encoding this layer. Default is Auto. Possible values
        /// include: 'Auto', 'Baseline', 'Main', 'High', 'High422', 'High444'
        /// </summary>
        [JsonProperty(PropertyName = "profile")]
        public H264VideoProfile? Profile { get; set; }

        /// <summary>
        /// Gets or sets describes which Level of the H.264 standard should be
        /// used when encoding this layer. The value can be Auto, or a number
        /// that matches the H264 Profile. If not specified, the default is
        /// Auto, which lets the encoder choose the Level that is appropriate
        /// for this layer.
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public string Level { get; set; }

        /// <summary>
        /// Gets or sets describes the VBV buffer window length. The value
        /// should be in ISO 8601 format. The default is PT5S or 5 seconds.
        /// </summary>
        [JsonProperty(PropertyName = "bufferWindow")]
        public System.TimeSpan? BufferWindow { get; set; }

        /// <summary>
        /// Gets or sets describes the number of reference frames to be used
        /// when encoding this layer. If not specified, the encoder determines
        /// an appropriate number based on the encoder complexity setting.
        /// </summary>
        [JsonProperty(PropertyName = "referenceFrames")]
        public int? ReferenceFrames { get; set; }

        /// <summary>
        /// Gets or sets describes the entropy mode to be used for this layer.
        /// If not specified, the encoder chooses the mode that is appropriate
        /// for the Profile and Level. Possible values include: 'Cabac',
        /// 'Cavlc'
        /// </summary>
        [JsonProperty(PropertyName = "entropyMode")]
        public EntropyMode? EntropyMode { get; set; }

    }
}
