// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Describes the basic properties for generating BMP thumbnails from the
    /// input video.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.BmpImage")]
    public partial class BmpImage : Image
    {
        /// <summary>
        /// Initializes a new instance of the BmpImage class.
        /// </summary>
        public BmpImage()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BmpImage class.
        /// </summary>
        /// <param name="label">Describes the optional label for the
        /// codec.</param>
        /// <param name="keyFrameInterval">Describes the distance between one
        /// key frame and the next, thereby defining a GOP or group of
        /// pictures. The value should be a non-zero integer in the range [1,
        /// .., 30], specified in ISO 8601 format. The default is 2
        /// seconds.</param>
        /// <param name="stretchMode">Describes the resizing mode - how the
        /// input video will be resized to fit the desired output
        /// resolution(s). Default is AutoSize. Possible values include:
        /// 'None', 'AutoSize', 'AutoFit'</param>
        /// <param name="start">Describes the position in the input video from
        /// where to start generating thumbnails. The value can be in absolute
        /// timestamp (ISO 8601, e.g: PT05S), or a frame count (e.g: 10 for the
        /// 10th frame), or a relative value (e.g: 1%). Also supports a special
        /// value {Best}, which tells the encoder to select the best thumbnail
        /// from the first few seconds of the video.</param>
        /// <param name="step">Describes the intervals at which thumbnails are
        /// generated. The value can be in absolute timestamp (ISO 8601, e.g:
        /// PT05S for one image every 5 seconds), or a frame count (e.g: 30 for
        /// every 30 frames), or a relative value (e.g: 1%).</param>
        /// <param name="range">Describes the position in the input video at
        /// which to stop generating thumbnails. The value can be in absolute
        /// timestamp (ISO 8601, e.g: PT5M30S to stop at 5 minutes and 30
        /// seconds), or a frame count (e.g: 300 to stop at the 300th frame),
        /// or a relative value (e.g: 100%).</param>
        public BmpImage(string label = default(string), System.TimeSpan? keyFrameInterval = default(System.TimeSpan?), StretchMode? stretchMode = default(StretchMode?), string start = default(string), string step = default(string), string range = default(string))
            : base(label, keyFrameInterval, stretchMode, start, step, range)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
