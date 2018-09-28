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
    /// TypeWriterAnnotation task. Information about predefined typewriter
    /// annotation.
    /// </summary>
    public partial class FlowApiTypewriterAnnotation : FlowApiWorkstepTask
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiTypewriterAnnotation
        /// class.
        /// </summary>
        public FlowApiTypewriterAnnotation() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiTypewriterAnnotation
        /// class.
        /// </summary>
        public FlowApiTypewriterAnnotation(bool? isEnabled = default(bool?), bool? isCompleted = default(bool?), bool? isRequired = default(bool?), string id = default(string), string displayName = default(string), int? docRefNumber = default(int?), string additionalInformation = default(string), string completedDataTime = default(string), string batchId = default(string), string taskType = default(string), int? pageNumber = default(int?), string textAlign = default(string), FlowApiPosition position = default(FlowApiPosition), string defaultText = default(string), string textFormat = default(string), string defaultTextType = default(string), FlowApiFontSettings fontSettings = default(FlowApiFontSettings), bool? isEditablePosition = default(bool?), bool? isEditableDefaultText = default(bool?), bool? isEditableFontSettings = default(bool?), string fontSettingsReference = default(string))
            : base(isEnabled, isCompleted, isRequired, id, displayName, docRefNumber, additionalInformation, completedDataTime, batchId, taskType)
        {
            PageNumber = pageNumber;
            TextAlign = textAlign;
            Position = position;
            DefaultText = defaultText;
            TextFormat = textFormat;
            DefaultTextType = defaultTextType;
            FontSettings = fontSettings;
            IsEditablePosition = isEditablePosition;
            IsEditableDefaultText = isEditableDefaultText;
            IsEditableFontSettings = isEditableFontSettings;
            FontSettingsReference = fontSettingsReference;
        }

        /// <summary>
        /// The page number the annotation is on.
        /// </summary>
        [JsonProperty(PropertyName = "PageNumber")]
        public int? PageNumber { get; set; }

        /// <summary>
        /// The typewriter annotation text alignment. Possible values include:
        /// 'Left', 'Right', 'Center'
        /// </summary>
        [JsonProperty(PropertyName = "TextAlign")]
        public string TextAlign { get; set; }

        /// <summary>
        /// The position of the predefined text annotation in lower left
        /// points.
        /// </summary>
        [JsonProperty(PropertyName = "Position")]
        public FlowApiPosition Position { get; set; }

        /// <summary>
        /// Default text shown by the client.
        /// </summary>
        [JsonProperty(PropertyName = "DefaultText")]
        public string DefaultText { get; set; }

        /// <summary>
        /// The format of the text. For example if the text should be a date,
        /// the date format can be specified. The client can than format the
        /// text accordingly.
        /// </summary>
        [JsonProperty(PropertyName = "TextFormat")]
        public string TextFormat { get; set; }

        /// <summary>
        /// The type of the predefined text annotation. If the client is
        /// familiar with the type it can display predefined values.
        /// </summary>
        [JsonProperty(PropertyName = "DefaultTextType")]
        public string DefaultTextType { get; set; }

        /// <summary>
        /// FontSetting to be used.
        /// </summary>
        [JsonProperty(PropertyName = "FontSettings")]
        public FlowApiFontSettings FontSettings { get; set; }

        /// <summary>
        /// Defines if the position can be edited by the client.
        /// </summary>
        [JsonProperty(PropertyName = "IsEditablePosition")]
        public bool? IsEditablePosition { get; set; }

        /// <summary>
        /// Specifies if the text can be changed by the user, or if it should
        /// be autofilled by the client without user interaction.
        /// </summary>
        [JsonProperty(PropertyName = "IsEditableDefaultText")]
        public bool? IsEditableDefaultText { get; set; }

        /// <summary>
        /// Defines if the 'fontSettings' can be edited by the client.
        /// </summary>
        [JsonProperty(PropertyName = "IsEditableFontSettings")]
        public bool? IsEditableFontSettings { get; set; }

        /// <summary>
        /// Reference to the FontSettings.
        /// </summary>
        [JsonProperty(PropertyName = "FontSettingsReference")]
        public string FontSettingsReference { get; private set; }

    }
}
