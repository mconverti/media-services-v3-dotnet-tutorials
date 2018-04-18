// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the basic properties for an output video layer.
    /// </summary>
    public partial class Layer
    {
        /// <summary>
        /// Initializes a new instance of the Layer class.
        /// </summary>
        public Layer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Layer class.
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
        public Layer(string width = default(string), string height = default(string), string label = default(string))
        {
            Width = width;
            Height = height;
            Label = label;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets describes the width of the output video for this
        /// layer. The value can be absolute (in pixels) or relative (in
        /// percentage). For example 50% means the output video has half as
        /// many pixels in width as the input.
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public string Width { get; set; }

        /// <summary>
        /// Gets or sets describes the height of the output video for this
        /// layer. The value can be absolute (in pixels) or relative (in
        /// percentage). For example 50% means the output video has half as
        /// many pixels in height as the input.
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public string Height { get; set; }

        /// <summary>
        /// Gets or sets describes the alphanumeric label for this layer, which
        /// can be used in multiplexing different video and audio layers, or in
        /// naming the output file.
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

    }
}
