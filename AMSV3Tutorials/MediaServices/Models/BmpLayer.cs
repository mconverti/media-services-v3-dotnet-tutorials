// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// This represents a layer in the BmpImage class.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.BmpLayer")]
    public partial class BmpLayer : Layer
    {
        /// <summary>
        /// Initializes a new instance of the BmpLayer class.
        /// </summary>
        public BmpLayer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BmpLayer class.
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
        public BmpLayer(string width = default(string), string height = default(string), string label = default(string))
            : base(width, height, label)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}