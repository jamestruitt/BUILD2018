// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// </auto-generated>

namespace Microsoft.Media.Encoding.Rest.ArmClient.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A video layer.
    /// </summary>
    [Newtonsoft.Json.JsonObject("#Microsoft.Media.VideoLayer")]
    public partial class VideoLayer : Layer
    {
        /// <summary>
        /// Initializes a new instance of the VideoLayer class.
        /// </summary>
        public VideoLayer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VideoLayer class.
        /// </summary>
        /// <param name="width">Gets or sets width of video in pixels for this
        /// layer.</param>
        /// <param name="height">Gets or sets height of video in pixels for
        /// this layer.</param>
        /// <param name="condition">Gets or sets the predicate to be evaluated
        /// before encoding this layer.</param>
        /// <param name="label">Gets or sets the label for this layer.</param>
        /// <param name="bitrate">Gets or sets the layer bitrate.</param>
        /// <param name="maxBitrate">Gets or sets the maximum rate the VBV
        /// buffer should be assumed to refill at.</param>
        /// <param name="bFrames">Gets or sets the number of B-frames to be
        /// used when encoding this layer.</param>
        /// <param name="frameRate">Gets or sets the frame rate for encoding
        /// this layer.</param>
        /// <param name="slices">Gets or sets the number of slice to be used
        /// when encoding this layer.</param>
        /// <param name="adaptiveBFrame">Gets or sets a value indicating
        /// whether adaptive b-frames are used for this layer.</param>
        public VideoLayer(string width = default(string), string height = default(string), string condition = default(string), string label = default(string), int? bitrate = default(int?), int? maxBitrate = default(int?), int? bFrames = default(int?), string frameRate = default(string), int? slices = default(int?), bool? adaptiveBFrame = default(bool?))
            : base(width, height, condition, label)
        {
            Bitrate = bitrate;
            MaxBitrate = maxBitrate;
            BFrames = bFrames;
            FrameRate = frameRate;
            Slices = slices;
            AdaptiveBFrame = adaptiveBFrame;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the layer bitrate.
        /// </summary>
        [JsonProperty(PropertyName = "bitrate")]
        public int? Bitrate { get; set; }

        /// <summary>
        /// Gets or sets the maximum rate the VBV buffer should be assumed to
        /// refill at.
        /// </summary>
        [JsonProperty(PropertyName = "maxBitrate")]
        public int? MaxBitrate { get; set; }

        /// <summary>
        /// Gets or sets the number of B-frames to be used when encoding this
        /// layer.
        /// </summary>
        [JsonProperty(PropertyName = "bFrames")]
        public int? BFrames { get; set; }

        /// <summary>
        /// Gets or sets the frame rate for encoding this layer.
        /// </summary>
        [JsonProperty(PropertyName = "frameRate")]
        public string FrameRate { get; set; }

        /// <summary>
        /// Gets or sets the number of slice to be used when encoding this
        /// layer.
        /// </summary>
        [JsonProperty(PropertyName = "slices")]
        public int? Slices { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether adaptive b-frames are used
        /// for this layer.
        /// </summary>
        [JsonProperty(PropertyName = "adaptiveBFrame")]
        public bool? AdaptiveBFrame { get; set; }

    }
}