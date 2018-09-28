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
    /// Attachment task.
    /// </summary>
    public partial class FlowApiAttachment : FlowApiWorkstepTask
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiAttachment class.
        /// </summary>
        public FlowApiAttachment() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiAttachment class.
        /// </summary>
        public FlowApiAttachment(bool? isEnabled = default(bool?), bool? isCompleted = default(bool?), bool? isRequired = default(bool?), string id = default(string), string displayName = default(string), int? docRefNumber = default(int?), string additionalInformation = default(string), string completedDataTime = default(string), string batchId = default(string), string taskType = default(string), int? positionPage = default(int?), FlowApiPosition position = default(FlowApiPosition), FlowApiSize size = default(FlowApiSize), string iconName = default(string), string appearanceImageDocumentId = default(string), string fileName = default(string))
            : base(isEnabled, isCompleted, isRequired, id, displayName, docRefNumber, additionalInformation, completedDataTime, batchId, taskType)
        {
            PositionPage = positionPage;
            Position = position;
            Size = size;
            IconName = iconName;
            AppearanceImageDocumentId = appearanceImageDocumentId;
            FileName = fileName;
        }

        /// <summary>
        /// Page number for the attachment.
        /// </summary>
        [JsonProperty(PropertyName = "PositionPage")]
        public int? PositionPage { get; set; }

        /// <summary>
        /// Exact position for the attachment.
        /// </summary>
        [JsonProperty(PropertyName = "Position")]
        public FlowApiPosition Position { get; set; }

        /// <summary>
        /// Width and Height of the object.
        /// </summary>
        [JsonProperty(PropertyName = "Size")]
        public FlowApiSize Size { get; set; }

        /// <summary>
        /// The name of the adobe default icon to be displayed. Values that
        /// should be displayed by most viewers are: 'Graph', 'PushPin',
        /// 'Paperclip' and 'Tag'. Others may be implemented by the pdf
        /// viewer. Default value: 'Paperclip' if no iconName or appearance
        /// image is given.
        /// </summary>
        [JsonProperty(PropertyName = "IconName")]
        public string IconName { get; set; }

        /// <summary>
        /// The document id of the image used for the appearance. If set this
        /// appearance overwrites the icon.
        /// </summary>
        [JsonProperty(PropertyName = "AppearanceImageDocumentId")]
        public string AppearanceImageDocumentId { get; set; }

        /// <summary>
        /// A hint for the client to name the attachment, but the name has to
        /// be set by the client.
        /// </summary>
        [JsonProperty(PropertyName = "FileName")]
        public string FileName { get; private set; }

    }
}