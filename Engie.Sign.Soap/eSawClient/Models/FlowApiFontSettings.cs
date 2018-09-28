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
    /// Configure fontsettings.
    /// </summary>
    public partial class FlowApiFontSettings
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiFontSettings class.
        /// </summary>
        public FlowApiFontSettings() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiFontSettings class.
        /// </summary>
        public FlowApiFontSettings(string id = default(string), FlowApiTextColor textColor = default(FlowApiTextColor), string name = default(string), double? size = default(double?), bool? isBold = default(bool?), bool? isItalic = default(bool?))
        {
            Id = id;
            TextColor = textColor;
            Name = name;
            Size = size;
            IsBold = isBold;
            IsItalic = isItalic;
        }

        /// <summary>
        /// Identification for the font.
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// Choose the color for the text.
        /// </summary>
        [JsonProperty(PropertyName = "TextColor")]
        public FlowApiTextColor TextColor { get; set; }

        /// <summary>
        /// Naming of the font.
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Define the size.
        /// </summary>
        [JsonProperty(PropertyName = "Size")]
        public double? Size { get; set; }

        /// <summary>
        /// Define if the font-style should be bold.
        /// </summary>
        [JsonProperty(PropertyName = "IsBold")]
        public bool? IsBold { get; set; }

        /// <summary>
        /// Define if the font-style should be italic.
        /// </summary>
        [JsonProperty(PropertyName = "IsItalic")]
        public bool? IsItalic { get; set; }

    }
}