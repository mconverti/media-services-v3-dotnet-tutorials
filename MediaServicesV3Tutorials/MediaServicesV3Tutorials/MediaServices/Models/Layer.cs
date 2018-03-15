// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Object to represent a video layer.
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
        /// <param name="width">Gets or sets width of video in pixels for this
        /// layer.</param>
        /// <param name="height">Gets or sets height of video in pixels for
        /// this layer.</param>
        /// <param name="condition">Gets or sets the predicate to be evaluated
        /// before encoding this layer.</param>
        /// <param name="label">Gets or sets the label for this layer.</param>
        public Layer(string width = default(string), string height = default(string), string condition = default(string), string label = default(string))
        {
            Width = width;
            Height = height;
            Condition = condition;
            Label = label;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets width of video in pixels for this layer.
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public string Width { get; set; }

        /// <summary>
        /// Gets or sets height of video in pixels for this layer.
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public string Height { get; set; }

        /// <summary>
        /// Gets or sets the predicate to be evaluated before encoding this
        /// layer.
        /// </summary>
        [JsonProperty(PropertyName = "condition")]
        public string Condition { get; set; }

        /// <summary>
        /// Gets or sets the label for this layer.
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; set; }

    }
}