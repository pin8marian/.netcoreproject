﻿// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace eSaw.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    /// <summary>
    /// Picture annotation tasks configuration.
    /// </summary>
    public partial class FlowApiPictureAnnotationConfiguration : FlowApiWorkstepTask
    {
        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiPictureAnnotationConfiguration class.
        /// </summary>
        public FlowApiPictureAnnotationConfiguration() { }

        /// <summary>
        /// Initializes a new instance of the
        /// FlowApiPictureAnnotationConfiguration class.
        /// </summary>
        public FlowApiPictureAnnotationConfiguration(bool? isEnabled = default(bool?), bool? isCompleted = default(bool?), bool? isRequired = default(bool?), string id = default(string), string displayName = default(string), int? docRefNumber = default(int?), string additionalInformation = default(string), string completedDataTime = default(string), string batchId = default(string), string taskType = default(string), string colorDepth = default(string), int? pageNumber = default(int?), int? minResolution = default(int?), int? maxResolution = default(int?), string name = default(string), FlowApiPosition position = default(FlowApiPosition), FlowApiSize size = default(FlowApiSize), bool? addAsAttachment = default(bool?))
            : base(isEnabled, isCompleted, isRequired, id, displayName, docRefNumber, additionalInformation, completedDataTime, batchId, taskType)
        {
            ColorDepth = colorDepth;
            PageNumber = pageNumber;
            MinResolution = minResolution;
            MaxResolution = maxResolution;
            Name = name;
            Position = position;
            Size = size;
            AddAsAttachment = addAsAttachment;
        }

        /// <summary>
        /// Possible values include: 'Color16M', 'Grayscale256'
        /// </summary>
        [JsonProperty(PropertyName = "ColorDepth")]
        public string ColorDepth { get; set; }

        /// <summary>
        /// The page number this element is on.
        /// </summary>
        [JsonProperty(PropertyName = "PageNumber")]
        public int? PageNumber { get; set; }

        /// <summary>
        /// Minimum resolution of the picture based on the target size.
        /// Default -1, means no min resolution.
        /// </summary>
        [JsonProperty(PropertyName = "MinResolution")]
        public int? MinResolution { get; set; }

        /// <summary>
        /// Maximum resolution of the picture based on the target size.
        /// Default -1, mans no max resolution.
        /// </summary>
        [JsonProperty(PropertyName = "MaxResolution")]
        public int? MaxResolution { get; set; }

        /// <summary>
        /// Defines the name that is used for the attachment.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Exact position of this element.
        /// </summary>
        [JsonProperty(PropertyName = "Position")]
        public FlowApiPosition Position { get; set; }

        /// <summary>
        /// Width and height of the element.
        /// </summary>
        [JsonProperty(PropertyName = "Size")]
        public FlowApiSize Size { get; set; }

        /// <summary>
        /// Define if the picture should be added as attachment to the
        /// document as well.
        /// </summary>
        [JsonProperty(PropertyName = "AddAsAttachment")]
        public bool? AddAsAttachment { get; set; }

    }
}