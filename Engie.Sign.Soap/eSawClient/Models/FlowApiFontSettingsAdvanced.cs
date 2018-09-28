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
    /// Configure fontsettings for some formfields.
    /// </summary>
    public partial class FlowApiFontSettingsAdvanced
    {
        /// <summary>
        /// Initializes a new instance of the FlowApiFontSettingsAdvanced
        /// class.
        /// </summary>
        public FlowApiFontSettingsAdvanced() { }

        /// <summary>
        /// Initializes a new instance of the FlowApiFontSettingsAdvanced
        /// class.
        /// </summary>
        public FlowApiFontSettingsAdvanced(string fontFamily = default(string), string textAlign = default(string), FlowApiTextColor textColor = default(FlowApiTextColor), string name = default(string), double? size = default(double?), bool? isBold = default(bool?), bool? isItalic = default(bool?))
        {
            FontFamily = fontFamily;
            TextAlign = textAlign;
            TextColor = textColor;
            Name = name;
            Size = size;
            IsBold = isBold;
            IsItalic = isItalic;
        }

        /// <summary>
        /// Defines the font-family.
        /// </summary>
        [JsonProperty(PropertyName = "FontFamily")]
        public string FontFamily { get; set; }

        /// <summary>
        /// Alignment of the text. Possible values include: 'Left', 'Right',
        /// 'Center'
        /// </summary>
        [JsonProperty(PropertyName = "TextAlign")]
        public string TextAlign { get; set; }

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
